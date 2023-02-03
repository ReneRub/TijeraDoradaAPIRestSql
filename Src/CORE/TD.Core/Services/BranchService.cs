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
    public class BranchService : IBranchService
    {
        private readonly ILogger<BranchService> logger;
        private readonly IMapper mapper;
        private readonly IBranchRepository branchRepository;
        private readonly IUnitOfWork unitOfWork;

        public BranchService(ILogger<BranchService> logger, IMapper mapper, IBranchRepository branchRepository, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.branchRepository = branchRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<StandardResponse<bool>> CreateBranch(BranchRequestDto branch)
        {
            var branchExist = await branchRepository.GetOne(x => x.Rfc == branch.Rfc && x.RazonSocial == branch.RazonSocial).ConfigureAwait(false);

            if (branchExist == null)
            {
                var branches = await branchRepository.GetAll();
                var lastBranchId = branches.OrderByDescending(x => x.CveSucursal).First();
                var newBranch = mapper.Map<CatSucursale>(branch);
                newBranch.CveSucursal = lastBranchId.CveSucursal + 1;
                await branchRepository.Add(newBranch).ConfigureAwait(false);
                var dbResponse = await unitOfWork.SaveAsync().ConfigureAwait(false);

                return dbResponse == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("AddBranchError"))
                    : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("AddSuccessBranch"), branch.Descripcion));
            }
            return new StandardResponse<bool>(HttpStatusCode.BadRequest, false, ResourcesManager.GetResourceValue("AddBranchError"));
        }

        public async Task<StandardResponse<List<BranchResponseDto>>> GetAllBranches()
        {
            var branches = await branchRepository
                  .GetAll()
                  .ConfigureAwait(false);

            var branchesDto = branches.Any() ? this.mapper.Map<IEnumerable<CatSucursale>, List<BranchResponseDto>>(branches.ToList()) : null;

            return branchesDto == null ? new StandardResponse<List<BranchResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound")) :
                new StandardResponse<List<BranchResponseDto>>(HttpStatusCode.OK, branchesDto, ResourcesManager.GetResourceValue("GetSuccess"));
        }

        public async Task<StandardResponse<bool>> UpdateBranch(int id, BranchRequestDto branch)
        {
            var branchUpd = await branchRepository.GetOne(x => x.CveSucursal == id).ConfigureAwait(false);

            if (branchUpd == null)
            {
                return new StandardResponse<bool>(HttpStatusCode.NotFound, false, message: ResourcesManager.GetResourceValue("UpdateBranchError"));
            }
            branchUpd.Descripcion = branch.Descripcion;
            branchUpd.Direccion = branch.Direccion;
            branchUpd.Rfc = branch.Rfc;
            branchUpd.RazonSocial = branch.RazonSocial;
            branchUpd.Telefono = branch.Telefono;
            branchUpd.HoraEntrada = branch.HoraEntrada;
            branchUpd.CveFranquicia = branch.CveFranquicia;
            branchUpd.CveCiudad = branch.CveCiudad;

            branchRepository.Update(branchUpd);

            var response = await unitOfWork.SaveAsync().ConfigureAwait(false);

            return response == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("UpdateBranchError"))
                   : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("UpdateBranch"), branchUpd.Descripcion));
        }
    }
}
