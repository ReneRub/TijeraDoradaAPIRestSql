using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Infrastructure.Abstraction.Entities;

namespace TD.Infrastructure.Abstraction.Repositories
{
    /// <summary>
    /// IEmployeeRepository
    /// </summary>
    public interface IEmployeeRepository : IRepository<CatEmpleado>
    {
        Task<IEnumerable<CatEmpleado>> GetStylist(int sucursal);

        Task<List<EmployeeStylistResponseDto>> GetAccessLogin(LoginRequestDto Credentials);

        Task<IEnumerable<CatEmpleado>> GetEmployees();

        Task<CatEmpleado> GetEmployee(int id);
    }
}
