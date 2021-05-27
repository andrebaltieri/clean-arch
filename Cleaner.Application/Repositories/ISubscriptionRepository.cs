using System.Threading.Tasks;
using Cleaner.Domain.Entities;

namespace Cleaner.Application.Repositories
{
    public interface ISubscriptionRepository
    {
        Task SaveAsync(Subscription subscription);
    }
}