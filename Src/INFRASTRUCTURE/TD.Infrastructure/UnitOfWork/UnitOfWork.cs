using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;
using TD.Infrastructure.Abstraction.UnitOfWork;
using TD.Infrastructure.Repositories;

namespace TD.Infrastructure.UnitOfWork
{
    /// <summary>
    /// UnitOfWork
    /// </summary>
    public sealed class UnitOfWork : IUnitOfWork
    {
        private Dictionary<Type, object> _repositories;
        private TIJERADORADAContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// UnitOfWork
        /// </summary>
        /// <param name="context">The context</param>
        public UnitOfWork(TIJERADORADAContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }

        /// <summary>
        /// GetRepository
        /// </summary>
        /// <typeparam name="T">Target type</typeparam>
        /// <returns>Returns an instance of T</returns>
        public IRepository<T> GetRepository<T>()
            where T : class
        {
            if (!_repositories.Keys.Contains(typeof(T)))
            {
                Repository<T> repository = new Repository<T>(_context);
                _repositories.Add(typeof(T), repository);
            }

            return (Repository<T>)_repositories[typeof(T)];
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_repositories != null)
            {
                _repositories.Clear();
                _repositories = null;
            }

            _context.Dispose();
        }

        /// <inheritdoc/>
        public int Save()
        {
            return _context.SaveChanges();
        }

        /// <inheritdoc/>
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
