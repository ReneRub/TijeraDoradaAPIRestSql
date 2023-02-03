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
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly IEmployeeService enployeeService;
        private readonly IResponseBuilder responseBuilder;

        public EmployeesController(
            ILogger<LoginController> logger,
            IMapper mapper,
            IEmployeeService enployeeService,
            IResponseBuilder responseBuilder)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.enployeeService = enployeeService;
            this.responseBuilder = responseBuilder;
        }

        /// <summary>
        /// Get Stylist Employee 
        /// </summary>
        /// <param name="sucursal">Sucursal Id</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetStylist")]
        //[Authorize]
        public async Task<IActionResult> GetStylistBySuc(int sucursal)
        {
            var result = await enployeeService.GetStylist(sucursal);

            return await responseBuilder
               .WithData(result)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Get Stylist Employee 
        /// </summary>
        /// <param name="sucursal">Sucursal Id</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetAllEmployees")]
        //[Authorize]
        public async Task<IActionResult> GetAllEmployees()
        {
            var result = await enployeeService.GetAllEmployees();

            return await responseBuilder
               .WithData(result)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Get Employee by cveEmp 
        /// </summary>
        /// <param name="id">CveEmpleado</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetEmployeeById")]
        //[Authorize]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var result = await enployeeService.GetEmployeeById(id);

            return await responseBuilder
               .WithData(result)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Update employee data
        /// </summary>
        /// <param name="id">The employee Id.</param>
        /// <param name="request">The data employee request</param>
        /// Common Response.
        /// </returns>
        [HttpPut("{id:required}UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeRequestDto request)
        {
            var result = await enployeeService.UpdateEmployee(id, request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Create employee
        /// </summary>
        /// <param name="request">The data employee request</param>
        /// Common Response.
        /// </returns>
        [HttpPost("CreateNewEmployee")]
        public async Task<IActionResult> AddEmployee(EmployeeRequestDto request)
        {
            var result = await enployeeService.CreateEmployee(request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }
    }
}
