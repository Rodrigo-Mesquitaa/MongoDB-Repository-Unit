using System;
using System.Threading.Tasks;

namespace GenericRepository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}