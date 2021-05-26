using Cleaner.Domain.Entities;
using Flunt.Notifications;
using Flunt.Validations;

namespace Cleaner.Domain.Specs
{
    public static class SubscriptionSpecs
    {
        public static Contract<Notification> EnsureCanSubscribe(this Subscription subscription)
        {
            // TODO: Raise Domain Event
            return new Contract<Notification>()
                .Requires()
                .IsNotNull(subscription.Payment, "Payment", "Pagamento inválido")
                .IsNotNull(subscription.Student, "Student", "Aluno inválido");
        }
    }
}