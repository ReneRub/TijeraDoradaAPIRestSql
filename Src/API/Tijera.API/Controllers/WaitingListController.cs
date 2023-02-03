using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TD.Core.Abstraction.Services;
using TD.Core.Services;
using Tijera.API.Shared.Results;

namespace Tijera.API.Controllers
{
    /// <summary>
    /// Employee Controller
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    public class WaitingListController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly IMapper mapper;
        private readonly IWaitingListService waitingListService;
        private readonly IResponseBuilder responseBuilder;

        public WaitingListController(ILogger<LoginController> logger, IMapper mapper, IWaitingListService waitingListService, IResponseBuilder responseBuilder)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.waitingListService = waitingListService;
            this.responseBuilder = responseBuilder;
        }

        /// <summary>
        /// Get WaitingList 
        /// </summary>
        /// <param name="franchise">Sucursal Id</param>
        /// <param name="branch">Sucursal Id</param>
        /// <returns>
        /// Common Response.
        /// </returns>
        [HttpGet("GetWaitingList")]
        //[Authorize]
        public async Task<IActionResult> GetWaitingList(int franchise, int branch)
        {
            var result = await waitingListService.GetWaitingList(franchise, branch);

            return await responseBuilder
               .WithData(result)
               .WithStatusCode(result.HttpStatusCode)
               .BuildAsync()
               .ConfigureAwait(false);

        }
    }
}
