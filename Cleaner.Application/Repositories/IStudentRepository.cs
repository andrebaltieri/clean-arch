using System;
using System.Threading.Tasks;
using Cleaner.Domain.Entities;

namespace Cleaner.Application.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> GetAsync(Guid id);
    }
}