using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Infrastructure.Abstraction.Entities;

namespace TD.Core.Abstraction.Services
{
    public interface ICustomerService
    {
        Task<StandardResponse<List<CustomerResponseDto>>> GetAllCustomers(string FirstName, string SurNAme, string LastName);

        Task<StandardResponse<bool>> UpdateCustomer(int id, CustomerRequestDto customer);

        Task<StandardResponse<CatCliente>> GetCustomerById(int id);

        Task<StandardResponse<bool>> CreateCustomer(CustomerRequestDto customer);
    }
}
