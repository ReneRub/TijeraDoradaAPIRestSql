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
    public class BranchesController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly IBranchService branchService;
        private readonly IResponseBuilder responseBuilder;

        public BranchesController(ILogger<LoginController> logger, IMapper mapper, IBranchService branchService, IResponseBuilder responseBuilder)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.branchService = branchService;
            this.responseBuilder = responseBuilder; 
        }

        /// <summary>
        /// Get all branches
        /// </summary>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetAllBranches")]
        //[Authorize]
        public async Task<IActionResult> GetAllBranches()
        {
            var result = await branchService.GetAllBranches();

            return await responseBuilder
               .WithData(result)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Update branch data
        /// </summary>
        /// <param name="id">The branch id.</param>
        /// <param name="request">The data branch request</param>
        /// Common Response.
        /// </returns>
        [HttpPut("{id:required}UpdateBranch")]
        public async Task<IActionResult> UpdateBranch(int id, BranchRequestDto request)
        {
            var result = await branchService.UpdateBranch(id, request).ConfigureAwait(false);

            return await responseBuilder
               .WithStatusCode(result.HttpStatusCode)
               .WithMessage(result.Message)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Create branch
        /// </summary>
        /// <param name="request">The data branch request</param>
        /// Common Response.
        /// </returns>
        [HttpPost("CreateNewBranch")]
        public async Task<IActionResult> AddBranch(BranchRequestDto request)
        {
            var result = await branchService.CreateBranch(request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }
    }
}
