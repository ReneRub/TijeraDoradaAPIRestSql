using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Infrastructure.Abstraction.Entities;

namespace TD.Core.Abstraction.Services
{
    public interface IEmployeeService
    {
        Task<StandardResponse<List<EmployeeStylistResponseDto>>> GetStylist(int sucursal);

        Task<StandardResponse<List<EmployeeResponseDto>>> GetAllEmployees();

        Task<StandardResponse<bool>> UpdateEmployee(int id, EmployeeRequestDto employee);

        Task<StandardResponse<CatEmpleado>> GetEmployeeById(int id);

        Task<StandardResponse<bool>> CreateEmployee(EmployeeRequestDto employee);
    }
}
