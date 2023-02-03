using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Infrastructure.Abstraction.UnitOfWork
{
    /// <summary>
    /// IUnitOfWork
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>()
            where T : class;

        int Save();

        Task<int> SaveAsync();
    }
}
