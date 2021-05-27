using System;
using System.Threading.Tasks;
using Cleaner.Application.Repositories;
using Cleaner.Application.Services;
using Cleaner.Domain.Entities;

namespace Cleaner.Application.UseCases.Subscribe
{
    public class SubscribeUseCase
    {
        private readonly IPayPalService _payPalService;
        private readonly IPlanRepository _planRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ISubscriptionRepository _subscriptionRepository;

        public SubscribeUseCase(
            IPayPalService payPalService,
            IPlanRepository planRepository,
            IStudentRepository studentRepository,
            ISubscriptionRepository subscriptionRepository)
        {
            _payPalService = payPalService;
            _planRepository = planRepository;
            _studentRepository = studentRepository;
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<Output> ExecuteAsync(Input input)
        {
            var student = await _studentRepository.GetAsync(input.StudentId);
            if (student == null)
                return new Output(Guid.Empty, 404, "Aluno não encontrado");

            var plan = await _planRepository.GetAsync(input.PlanId);
            if (plan == null)
                return new Output(Guid.Empty, 404, "Plano não encontrado");

            var payment = await _payPalService.CreateSubscription(student.Email.Address, input.CreditCard);
            if (payment == null)
                return new Output(Guid.Empty, 400, "Falha ao processar pagamento");

            try
            {
                var subscription = new Subscription(payment, student, plan);
                subscription.Subscribe();
                if (!subscription.IsValid)
                    return new Output(Guid.Empty, 400, "Assinatura inválida");
                
                await _subscriptionRepository.SaveAsync(subscription);
                return new Output(subscription.Id);
            }
            catch
            {
                // LOG 
                await _payPalService.RefundAsync(student.Email.Address, input.CreditCard);
                return new Output(Guid.Empty, 400, "Assinatura inválida");
            }
        }
    }
}