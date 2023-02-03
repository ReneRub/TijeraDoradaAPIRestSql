using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Infrastructure.Repositories
{
    /// <summary>
    /// Class Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T>
        where T : class
    {
        protected DbContext Context { get; private set; }

        private DbSet<T> _dbset;

        public Repository(DbContext context)
        {
            this.Context = context;
            _dbset = context?.Set<T>();
        }

        /// <inheritdoc/>
        public async Task<T> GetDetachedRecord(Expression<Func<T, bool>> predicate)
        {
            return (await _dbset.AsNoTracking().Where(predicate).ToListAsync().ConfigureAwait(false)).FirstOrDefault();
        }

        /// <inheritdoc/>
        public async Task<List<T>> GetDetachedRecords(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.AsNoTracking().Where(predicate).ToListAsync().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<T> GetById(long id)
        {
            return await _dbset.FindAsync(id);
        }

        /// <inheritdoc/>
        public async Task<T> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        /// <inheritdoc/>
        public async Task<T> GetById(string id)
        {
            return await _dbset.FindAsync(id);
        }

        /// <inheritdoc/>
        public async Task<T> GetById(Guid id)
        {
            return await _dbset.FindAsync(id);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbset.ToListAsync().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.Where(predicate).ToListAsync().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<T> GetOne(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.FirstOrDefaultAsync(predicate).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate, int page, int pageSize)
        {
            return await _dbset.Where(predicate).Skip(pageSize * (page - 1)).Take(pageSize).ToListAsync().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<T> GetOneByOrder<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> keySelector, System.ComponentModel.ListSortDirection sortOrder)
        {
            if (sortOrder == System.ComponentModel.ListSortDirection.Ascending)
            {
                return await _dbset.Where(predicate).OrderBy(keySelector).FirstOrDefaultAsync().ConfigureAwait(false);
            }
            else
            {
                return await _dbset.Where(predicate).OrderByDescending(keySelector).FirstOrDefaultAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> GetAllByOrder<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> keySelector, System.ComponentModel.ListSortDirection sortOrder)
        {
            if (sortOrder == System.ComponentModel.ListSortDirection.Ascending)
            {
                return await _dbset.Where(predicate).OrderBy(keySelector).ToListAsync().ConfigureAwait(false);
            }
            else
            {
                return await _dbset.Where(predicate).OrderByDescending(keySelector).ToListAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<T> Add(T entity)
        {
            var result = await _dbset.AddAsync(entity);
            return result.Entity;
        }

        /// <inheritdoc/>
        public async Task Add(IEnumerable<T> entities)
        {
            await _dbset.AddRangeAsync(entities).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IQueryable<T> GetTable()
        {
            return _dbset.AsQueryable();
        }

        /// <inheritdoc/>
        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        /// <inheritdoc/>
        public void Remove(IEnumerable<T> entities)
        {
            _dbset.RemoveRange(entities);
        }

        /// <inheritdoc />
        public void Update(T entity)
        {
            Context.Update(entity);
        }

        /// <inheritdoc />
        //public async Task<int> DeleteDataByStoreProcedure(string externalEngagementId, string tableName)
        //{
        //    var deleteTableQuery = RawSqlBuilder
        //                .Create()
        //                .Append("EXEC " + StoredProcedureDefinitions.DeleteTable + " ")
        //                .Append("'" + externalEngagementId + "', ")
        //                .Append("'" + tableName + "'")
        //                .BuildString();

        //    var totalRowsDeleted = Context
        //                           .Database
        //                           .ExecuteSqlInterpolated(deleteTableQuery);

        //    return totalRowsDeleted;
        //}
    }
}
