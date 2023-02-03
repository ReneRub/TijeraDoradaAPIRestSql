using TD.Infrastructure.Abstraction.Entities;

namespace TD.Infrastructure.Abstraction.Repositories
{
    /// <summary>
    /// ICustomerRepository
    /// </summary>
    public interface ICustomerRepository : IRepository<CatCliente>
    {
        Task<IEnumerable<CatCliente>> GetCustomers(string FirstName, string SurNAme, string LastName);
    }
}
