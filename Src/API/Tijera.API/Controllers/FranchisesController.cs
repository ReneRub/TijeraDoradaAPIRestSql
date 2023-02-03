using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TD.Contracts.Dtos.Request;
using TD.Core.Abstraction.Services;
using Tijera.API.Shared.Results;

namespace Tijera.API.Controllers
{
    /// <summary>
    /// Branches Controller
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    public class FranchisesController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly IFranchiseService franchiseService;
        private readonly IResponseBuilder responseBuilder;

        public FranchisesController(ILogger<LoginController> logger, IMapper mapper, IFranchiseService franchiseService, IResponseBuilder responseBuilder)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.franchiseService = franchiseService;
            this.responseBuilder = responseBuilder;
        }

        /// <summary>
        /// Get all franchises
        /// </summary>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetAllFranchises")]
        //[Authorize]
        public async Task<IActionResult> GetAllFranchises()
        {
            var result = await franchiseService.GetAllFranchises();

            return await responseBuilder
               .WithData(result)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Update franchise data
        /// </summary>
        /// <param name="id">The franchise id.</param>
        /// <param name="request">The data franchise request</param>
        /// Common Response.
        /// </returns>
        [HttpPut("{id:required}/Updatefranchise")]
        public async Task<IActionResult> UpdateFranchise(int id, FranchiseRequestDto request)
        {
            var result = await franchiseService.UpdateFranchise(id, request).ConfigureAwait(false);

            return await responseBuilder
               .WithStatusCode(result.HttpStatusCode)
               .WithMessage(result.Message)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Create franchise
        /// </summary>
        /// <param name="request">The data franchise request</param>
        /// Common Response.
        /// </returns>
        [HttpPost("CreateNewFranchise")]
        public async Task<IActionResult> AddFranchise(FranchiseRequestDto request)
        {
            var result = await franchiseService.CreateFranchise(request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }
    }
}
