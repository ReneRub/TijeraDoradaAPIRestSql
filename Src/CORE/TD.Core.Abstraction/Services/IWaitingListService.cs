using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;

namespace TD.Core.Abstraction.Services
{
    public interface IWaitingListService
    {
        Task<StandardResponse<List<WaitingListResponseDto>>> GetWaitingList(int francise, int branch);

        Task<StandardResponse<bool>> UpdateWaitingList(int id, int status);

        Task<StandardResponse<bool>> AddCustomerToList(WaitingListRequestDto customer);
    }
}
