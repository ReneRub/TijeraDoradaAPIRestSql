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
    /// <summary>
    /// WaitingList Service
    /// </summary>
    public class WaitingListService : IWaitingListService
    {
        private readonly ILogger<WaitingListService> logger;
        private readonly IMapper mapper;
        private readonly IWaitingListRepository waitingListRepository;
        private readonly IUnitOfWork unitOfWork;

        public WaitingListService(ILogger<WaitingListService> logger, IMapper mapper, IWaitingListRepository waitingListRepository, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.waitingListRepository = waitingListRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Add Customer To WaitingList
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<StandardResponse<bool>> AddCustomerToList(WaitingListRequestDto customer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get WaitingList
        /// </summary>
        /// <param name="franchise"></param>
        /// <param name="branch"></param>
        /// <returns></returns>
        public async Task<StandardResponse<List<WaitingListResponseDto>>> GetWaitingList(int franchise, int branch)
        {
            var waitingList = await waitingListRepository
                .GetWaitingList(franchise, branch)
                .ConfigureAwait(false);

            var waitingListDto = waitingList.Any() ? this.mapper.Map<List<ListaEspera>, List<WaitingListResponseDto>>(waitingList.ToList()) : null;

            return waitingListDto == null ? new StandardResponse<List<WaitingListResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound"))
                : new StandardResponse<List<WaitingListResponseDto>>(HttpStatusCode.OK, waitingListDto, ResourcesManager.GetResourceValue("GetSuccess"));

        }

        /// <summary>
        /// Update Waiting List
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task<StandardResponse<bool>> UpdateWaitingList(int id, int status)
        {
            var waitingListUpd = await waitingListRepository.GetOne(x => x.CveListaEspera == id).ConfigureAwait(false);

            if (waitingListUpd == null)
            {
                return new StandardResponse<bool>(HttpStatusCode.NotFound, false, message: ResourcesManager.GetResourceValue("UpdateWaitingListError"));
            }
            waitingListUpd.CveStatusLista = status;

            var response = await unitOfWork.SaveAsync().ConfigureAwait(false);

            return response == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("UpdateWaitingListError"))
                   : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("UpdateWaitingList"), waitingListUpd.CveCliente));
        }
    }
}
