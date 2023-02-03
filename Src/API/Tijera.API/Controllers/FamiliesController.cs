using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TD.Contracts.Dtos.Request;
using TD.Core.Abstraction.Services;
using TD.Core.Services;
using Tijera.API.Shared.Results;

namespace Tijera.API.Controllers
{
    /// <summary>
    /// Families Controller
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    public class FamiliesController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly IFamilyService familyService;
        private readonly IResponseBuilder responseBuilder;

        public FamiliesController(ILogger<LoginController> logger, IMapper mapper, IFamilyService familyService, IResponseBuilder responseBuilder)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.familyService = familyService;
            this.responseBuilder = responseBuilder; 
        }

        /// <summary>
        /// Get all families
        /// </summary>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetAllFamilies")]
        //[Authorize]
        public async Task<IActionResult> GetAllFamilies()
        {
            var result = await familyService.GetAllFamilies();

            return await responseBuilder
               .WithData(result)
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Update family data
        /// </summary>
        /// <param name="id">The family id.</param>
        /// <param name="request">The data family request</param>
        /// Common Response.
        /// </returns>
        [HttpPut("{id:required}UpdateFamily")]
        public async Task<IActionResult> UpdateFamily(int id, familyRequestDto request)
        {
            var result = await familyService.UpdateFamily(id, request).ConfigureAwait(false);

            return await responseBuilder
               .WithStatusCode(result.HttpStatusCode)
               .WithMessage(result.Message)
               .BuildAsync()
               .ConfigureAwait(false);

        }

        /// <summary>
        /// Create family
        /// </summary>
        /// <param name="request">The data family request</param>
        /// Common Response.
        /// </returns>
        [HttpPost("CreateNewFamily")]
        public async Task<IActionResult> AddFamily(familyRequestDto request)
        {
            var result = await familyService.CreateFamily(request).ConfigureAwait(false);

            return await responseBuilder
               .WithMessage(result.Message)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }
    }
}
