using System.Threading.Tasks;
using Cleaner.Application.Models;
using Cleaner.Domain.Entities;

namespace Cleaner.Application.Services
{
    public interface IPayPalService
    {
        Task<Payment> CreateSubscription(string email, CreditCard creditCard);
        Task RefundAsync(string email, CreditCard creditCard);
    }
}