using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TD.Contracts.Dtos.Request;
using TD.Core.Abstraction.Services;
using TD.Core.Services;
using Tijera.API.Shared.Results;

namespace Tijera.API.Controllers
{
    /// <summary>
    /// Products And Services Controller
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    public class ProductAndServicesController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly IProductAndServicesService productAndServicesService;
        private readonly IResponseBuilder responseBuilder;

        public ProductAndServicesController(ILogger<LoginController> logger, IMapper mapper, IProductAndServicesService productAndServicesService, IResponseBuilder responseBuilder)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.productAndServicesService = productAndServicesService;
            this.responseBuilder = responseBuilder;
        }

        /// <summary>
        /// Get Products And Services By Family
        /// </summary>
        /// <param name="FamilyId">FirstName</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetProductsAndServicesByFamily")]
        //[Authorize]
        public async Task<IActionResult> GetAllProductsAndServices(int FamilyId)
        {
            var result = await productAndServicesService.GetProdAndServById(FamilyId);

            return await responseBuilder
               .WithData(result)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Update ProdAndServ data
        /// </summary>
        /// <param name="id">The Prod And Serv Id.</param>
        /// <param name="request">The data ProdAndServ request</param>
        /// Common Response.
        /// </returns>
        [HttpPut("{id:required}UpdateProdAndServ")]
        public async Task<IActionResult> UpdateProdAndServ(int id, ProdAndServRequestDto request)
        {
            var result = await productAndServicesService.UpdateProdAndServ(id, request).ConfigureAwait(false);

            return await responseBuilder
               .WithStatusCode(result.HttpStatusCode)
               .WithMessage(result.Message)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Create customer
        /// </summary>
        /// <param name="request">The data product and serv request</param>
        /// Common Response.
        /// </returns>
        [HttpPost("CreateNewProductOrService")]
        public async Task<IActionResult> AddProdAndServ(ProdAndServRequestDto request)
        {
            var result = await productAndServicesService.CreateProdServ(request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }
    }
}
