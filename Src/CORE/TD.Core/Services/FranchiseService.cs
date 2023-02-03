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
    public class FranchiseService : IFranchiseService
    {
        private readonly ILogger<FranchiseService> logger;
        private readonly IMapper mapper;
        private readonly IFranchiseRepository franchiseRepository;
        private readonly IUnitOfWork unitOfWork;

        public FranchiseService(ILogger<FranchiseService> logger, IMapper mapper, IFranchiseRepository franchiseRepository, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.franchiseRepository = franchiseRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<StandardResponse<bool>> CreateFranchise(FranchiseRequestDto franchise)
        {
            var franchiseExist = await franchiseRepository.GetOne(x => x.Descripcion == franchise.Descripcion).ConfigureAwait(false);

            if (franchiseExist == null)
            {
                var franchises = await franchiseRepository.GetAll();
                var lastFranchiseId = franchises.OrderByDescending(x => x.CveFranquicia).First();
                var newFranchise = mapper.Map<CatFranquicia>(franchise);
                newFranchise.CveFranquicia = lastFranchiseId.CveFranquicia + 1;
                newFranchise.FechaCreacion = DateTime.Now;
                await franchiseRepository.Add(newFranchise).ConfigureAwait(false);
                var dbResponse = await unitOfWork.SaveAsync().ConfigureAwait(false);

                return dbResponse == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("AddFranchiseError"))
                    : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("AddSuccessFranchise"), franchise.Descripcion));
            }
            return new StandardResponse<bool>(HttpStatusCode.BadRequest, false, ResourcesManager.GetResourceValue("AddFranchiseError"));
        }

        public async Task<StandardResponse<List<FranchiseResponseDto>>> GetAllFranchises()
        {
            var franchises = await franchiseRepository
                  .GetAll()
                  .ConfigureAwait(false);

            var franchisesDto = franchises.Any() ? this.mapper.Map<IEnumerable<CatFranquicia>, List<FranchiseResponseDto>>(franchises.ToList()) : null;

            return franchisesDto == null ? new StandardResponse<List<FranchiseResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound")) :
                new StandardResponse<List<FranchiseResponseDto>>(HttpStatusCode.OK, franchisesDto, ResourcesManager.GetResourceValue("GetSuccess"));
        }

        public async Task<StandardResponse<bool>> UpdateFranchise(int id, FranchiseRequestDto franchise)
        {
            var franchiseUpd = await franchiseRepository.GetOne(x => x.CveFranquicia == id).ConfigureAwait(false);

            if (franchiseUpd == null)
            {
                return new StandardResponse<bool>(HttpStatusCode.NotFound, false, message: ResourcesManager.GetResourceValue("UpdateFranchiseError"));
            }
            franchiseUpd.Descripcion = franchise.Descripcion;
            franchiseUpd.UsuarioCreador = franchise.UsuarioCreador;
            franchiseUpd.EstaActivo = franchise.EstaActivo;

            franchiseRepository.Update(franchiseUpd);

            var response = await unitOfWork.SaveAsync().ConfigureAwait(false);

            return response == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("UpdateFranchiseError"))
                   : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("UpdateFranchise"), franchiseUpd.Descripcion));
        }
    }
}
