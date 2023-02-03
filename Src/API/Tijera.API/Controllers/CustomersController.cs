using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TD.Contracts.Dtos.Request;
using TD.Core.Abstraction.Services;
using Tijera.API.Shared.Results;

namespace Tijera.API.Controllers
{
    /// <summary>
    /// Employee Controller
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly ICustomerService customerService;
        private readonly IResponseBuilder responseBuilder;

        public CustomersController(ILogger<LoginController> logger, IMapper mapper, ICustomerService customerService, IResponseBuilder responseBuilder)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.customerService = customerService;
            this.responseBuilder = responseBuilder;
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <param name="FirstName">FirstName</param>
        /// <param name="SurName">SurName</param>
        /// <param name="LastName">LastName</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetCustomers")]
        //[Authorize]
        public async Task<IActionResult> GetAllCustomers(string? FirstName, string? LastName, string? SurName)
        {
            var result = await customerService.GetAllCustomers(FirstName, SurName, LastName);

            return await responseBuilder
               .WithData(result)
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Get Customer by cveClient 
        /// </summary>
        /// <param name="id">CveEmpleado</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetCustomerById")]
        //[Authorize]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var result = await customerService.GetCustomerById(id);

            return await responseBuilder
               .WithData(result)
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Update customer data
        /// </summary>
        /// <param name="id">The Customer Id.</param>
        /// <param name="request">The data employee request</param>
        /// Common Response.
        /// </returns>
        [HttpPut("{id:required}UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer(int id, CustomerRequestDto request)
        {
            var result = await customerService.UpdateCustomer(id, request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Create customer
        /// </summary>
        /// <param name="request">The data customer request</param>
        /// Common Response.
        /// </returns>
        [HttpPost("CreateNewCustomer")]
        public async Task<IActionResult> AddCustomer(CustomerRequestDto request)
        {
            var result = await customerService.CreateCustomer(request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }
    }
}
