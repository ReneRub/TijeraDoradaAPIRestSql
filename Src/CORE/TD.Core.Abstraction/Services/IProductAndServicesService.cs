using TD.Common;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;

namespace TD.Core.Abstraction.Services
{
    public interface IProductAndServicesService
    {
        Task<StandardResponse<List<ProdAndServResponseDto>>> GetProdAndServById(int FamilyId);
        Task<StandardResponse<bool>> UpdateProdAndServ(int id, ProdAndServRequestDto prodAndServ);
        Task<StandardResponse<bool>> CreateProdServ(ProdAndServRequestDto prodAndServ);
    }
}
