using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Net;
using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Core.Abstraction.Services;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;
using TD.Infrastructure.Abstraction.UnitOfWork;

namespace TD.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<EmployeeService> logger;
        private readonly IMapper mapper;
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ILogger<EmployeeService> logger, IMapper mapper, ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.logger = logger;
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<StandardResponse<bool>> CreateCustomer(CustomerRequestDto customer)
        {
            var name = customer.Nombres;
            var phone = customer.Telefono;

            var customerExist = await customerRepository.GetOne(x => x.Telefono == phone && x.Nombres == name).ConfigureAwait(false);

            if (customerExist == null)
            {
                var customers = await customerRepository.GetAll();
                var lastCustomerId = customers.OrderByDescending(x => x.CveCliente).First();
                var newCustomer = mapper.Map<CatCliente>(customer);
                newCustomer.CveCliente = lastCustomerId.CveCliente + 1;
                await customerRepository.Add(newCustomer).ConfigureAwait(false);
                var dbResponse = await unitOfWork.SaveAsync().ConfigureAwait(false);

                return dbResponse == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("AddCustomerError"))
                    : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("AddSuccessClient"), customer.Nombres));
            }
            return new StandardResponse<bool>(HttpStatusCode.BadRequest, false, ResourcesManager.GetResourceValue("AddCustomerError"));
        }

        /// <summary>
        /// Get all customers
        /// </summary>
        public async Task<StandardResponse<List<CustomerResponseDto>>> GetAllCustomers(string FirstName, string SurNAme, string LastName)
        {
            var customer = customerRepository.GetTable();

            if (!string.IsNullOrEmpty(FirstName))
            {
                customer =  customer.Where(d => d.Nombres.Contains(FirstName.Trim()));
            }
            if (!string.IsNullOrEmpty(SurNAme))
            {
                customer = customer.Where(d => d.Apemat.Contains(SurNAme.Trim()));
            }
            if (!string.IsNullOrEmpty(LastName))
            {
                customer = customer.Where(d => d.Apepat.Contains(LastName.Trim()));
            }

            var customerDto = customer.Any() ? this.mapper.Map<IEnumerable<CatCliente>, List<CustomerResponseDto>>(customer.ToList()) : null;

            return customerDto == null ? new StandardResponse<List<CustomerResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound")) :
                new StandardResponse<List<CustomerResponseDto>>(HttpStatusCode.OK, customerDto, ResourcesManager.GetResourceValue("GetSuccess"));
        }

        /// <summary>
        /// Get Customer By Id
        /// </summary>
        public async Task<StandardResponse<CatCliente>> GetCustomerById(int id)
        {
            var employee = await customerRepository
                .GetOne(x => x.CveCliente == id)
                .ConfigureAwait(false);

            return employee == null ? new StandardResponse<CatCliente>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound"))
                : new StandardResponse<CatCliente>(HttpStatusCode.OK, employee, ResourcesManager.GetResourceValue("GetSuccess"));

        }

        /// <summary>
        /// Update Customer
        /// </summary>
        public async Task<StandardResponse<bool>> UpdateCustomer(int id, CustomerRequestDto customer)
        {           
            var customerUpd = await customerRepository.GetOne(x => x.CveCliente == id).ConfigureAwait(false);

            if (customerUpd == null)
            {
                return new StandardResponse<bool>(HttpStatusCode.NotFound, false, message: ResourcesManager.GetResourceValue("UpdateCustomerError"));
            }
            customerUpd.Apepat = customer.Apepat;
            customerUpd.Apemat = customer.Apemat;
            customerUpd.Nombres = customer.Nombres;
            customerUpd.CveCiudad = customer.CveCiudad;
            customerUpd.CveColonia = customer.CveColonia;
            customerUpd.Telefono = customer.Telefono;
            customerUpd.Email = customer.Email;
            customerUpd.FechaRegistro = customer.FechaRegistro;
            customerUpd.CveSucursal = customer.CveSucursal;
            customerUpd.Sellos = customer.Sellos;
            customerUpd.CortesGratis = customer.CortesGratis;
            customerUpd.VentasAcum = customer.VentasAcum;
            customerUpd.FechaUltVta = customer.FechaUltVta;

            customerRepository.Update(customerUpd);

            var response = await unitOfWork.SaveAsync().ConfigureAwait(false);

            return response == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("UpdateCustomerError"))
                   : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("UpdateCustomer"), customerUpd.Nombres));

        }
    }
}
