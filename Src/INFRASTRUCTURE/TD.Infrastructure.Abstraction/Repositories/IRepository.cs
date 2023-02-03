using System.Linq.Expressions;

namespace TD.Infrastructure.Abstraction.Repositories
{
    /// <summary>
    /// IRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
        where T : class
    {
        Task<T> GetDetachedRecord(Expression<Func<T, bool>> predicate);

        Task<List<T>> GetDetachedRecords(Expression<Func<T, bool>> predicate);

        Task<T> GetById(long id);

        Task<T> GetById(int id);

        Task<T> GetById(string id);

        Task<T> GetById(Guid id);

        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);

        Task<T> GetOne(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate, int page, int pageSize);

        Task<T> GetOneByOrder<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> keySelector, System.ComponentModel.ListSortDirection sortOrder);

        Task<IEnumerable<T>> GetAllByOrder<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> keySelector, System.ComponentModel.ListSortDirection sortOrder);

        Task<T> Add(T entity);

        Task Add(IEnumerable<T> entities);

        IQueryable<T> GetTable();

        void Remove(T entity);

        void Remove(IEnumerable<T> entities);

        void Update(T entity);

        //Task<int> DeleteDataByStoreProcedure(string externalEngagementId, string tableName);
    }
}
