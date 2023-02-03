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
    /// Class ProductAndServicesService
    /// </summary>
    public class ProductAndServicesService : IProductAndServicesService
    {
        private readonly ILogger<ProductAndServicesService> logger;
        private readonly IMapper mapper;
        private readonly IProductAndServicesRepository productAndServicesRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProductAndServicesService(ILogger<ProductAndServicesService> logger, IMapper mapper,
            IProductAndServicesRepository productAndServicesRepository, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.productAndServicesRepository = productAndServicesRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<StandardResponse<bool>> CreateProdServ(ProdAndServRequestDto prodAndServ)
        {
            var prodServExist = await productAndServicesRepository.GetOne(x => x.NombreCorto == prodAndServ.NombreCorto && x.Descripcion == prodAndServ.Descripcion).ConfigureAwait(false);

            if (prodServExist == null)
            {
                var prodServs = await productAndServicesRepository.GetAll();
                var lastProsServId = prodServs.OrderByDescending(x => x.CveProdServ).First();
                var newprodServ = mapper.Map<CatProdServ>(prodAndServ);
                newprodServ.CveProdServ = lastProsServId.CveProdServ + 1;
                await productAndServicesRepository.Add(newprodServ).ConfigureAwait(false);
                var dbResponse = await unitOfWork.SaveAsync().ConfigureAwait(false);

                return dbResponse == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("AddProdServError"))
                    : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("AddSuccessProdServ"), prodAndServ.Descripcion));
            }
            return new StandardResponse<bool>(HttpStatusCode.BadRequest, false, ResourcesManager.GetResourceValue("AddProdServError"));
        }

        /// <summary>
        /// Get Products and services By FamilyId
        /// </summary>
        public async Task<StandardResponse<List<ProdAndServResponseDto>>> GetProdAndServById(int FamilyId)
        {
            var prodAndServ = await productAndServicesRepository
                .Get(x => x.CveFamilia == FamilyId)
                .ConfigureAwait(false);

            var prodAndServDto = prodAndServ.Any() ? this.mapper.Map<IEnumerable<CatProdServ>, List<ProdAndServResponseDto>>(prodAndServ.ToList()) : null;

            return prodAndServDto == null ? new StandardResponse<List<ProdAndServResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound"))
                : new StandardResponse<List<ProdAndServResponseDto>>(HttpStatusCode.OK, prodAndServDto, ResourcesManager.GetResourceValue("GetSuccess"));
        }
        /// <summary>
        /// Update products and services
        /// </summary>
        public async Task<StandardResponse<bool>> UpdateProdAndServ(int id, ProdAndServRequestDto prodAndServ)
        {
            var prodSerUpd = await productAndServicesRepository.GetOne(x => x.CveProdServ == id).ConfigureAwait(false);

            if (prodSerUpd == null)
            {
                return new StandardResponse<bool>(HttpStatusCode.NotFound, false, message: ResourcesManager.GetResourceValue("UpdateProdServError"));
            }
            prodSerUpd.CveFamilia = prodAndServ.CveFamilia;
            prodSerUpd.CveProveedor = prodAndServ.CveProveedor;
            prodSerUpd.NombreCorto = prodAndServ.NombreCorto;
            prodSerUpd.Descripcion = prodAndServ.Descripcion;
            prodSerUpd.Precio = prodAndServ.Precio;
            prodSerUpd.Existencia = prodAndServ.Existencia;
            prodSerUpd.CveStatus = prodAndServ.CveStatus;

            productAndServicesRepository.Update(prodSerUpd);

            var response = await unitOfWork.SaveAsync().ConfigureAwait(false);

            return response == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("UpdateProdServError"))
                   : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("UpdateProdServ"), prodSerUpd.NombreCorto));
        }
    }
}
