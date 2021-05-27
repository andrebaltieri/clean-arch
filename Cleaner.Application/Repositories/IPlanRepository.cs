using System;
using System.Threading.Tasks;
using Cleaner.Domain.Entities;

namespace Cleaner.Application.Repositories
{
    public interface IPlanRepository
    {
        Task<Plan> GetAsync(Guid planId);
    }
}