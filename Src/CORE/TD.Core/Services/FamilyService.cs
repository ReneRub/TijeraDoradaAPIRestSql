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
    public class FamilyService : IFamilyService
    {
        private readonly ILogger<EmployeeService> logger;
        private readonly IMapper mapper;
        private readonly IFamilyRepository familyRepository;
        private readonly IUnitOfWork unitOfWork;

        public FamilyService(ILogger<EmployeeService> logger, IMapper mapper, IFamilyRepository familyRepository, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.familyRepository = familyRepository;
            this.unitOfWork = unitOfWork;   
        }

        public async Task<StandardResponse<bool>> CreateFamily(familyRequestDto family)
        {
            var familyExist = await familyRepository.GetOne(x => x.Descripcion == family.Descripcion && x.CveTipoFamilia == family.CveTipoFamilia).ConfigureAwait(false);

            if (familyExist == null)
            {
                var families = await familyRepository.GetAll();
                var lastFamilyId = families.OrderByDescending(x => x.CveFamilia).First();
                var newFamily = mapper.Map<CatFamilia>(family);
                newFamily.CveFamilia = lastFamilyId.CveFamilia + 1;
                await familyRepository.Add(newFamily).ConfigureAwait(false);
                var dbResponse = await unitOfWork.SaveAsync().ConfigureAwait(false);

                return dbResponse == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("AddFamilyError"))
                    : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("AddSuccessFamily"), family.Descripcion));
            }
            return new StandardResponse<bool>(HttpStatusCode.BadRequest, false, ResourcesManager.GetResourceValue("AddFamilyError"));
        }

        public async Task<StandardResponse<List<FamilyResponseDto>>> GetAllFamilies()
        {
            var families = await familyRepository
                .GetAll()
                .ConfigureAwait(false);

            var familiesDto = families.Any() ? this.mapper.Map<IEnumerable<CatFamilia>, List<FamilyResponseDto>>(families.ToList()) : null;

            return familiesDto == null ? new StandardResponse<List<FamilyResponseDto>>(HttpStatusCode.NotFound, message: ResourcesManager.GetResourceValue("NotFound")) :
                new StandardResponse<List<FamilyResponseDto>>(HttpStatusCode.OK, familiesDto,message: ResourcesManager.GetResourceValue("GetSuccess"));
        }

        public async Task<StandardResponse<bool>> UpdateFamily(int id, familyRequestDto family)
        {
            var familyUpd = await familyRepository.GetOne(x => x.CveFamilia == id).ConfigureAwait(false);

            if (familyUpd == null)
            {
                return new StandardResponse<bool>(HttpStatusCode.NotFound, false, message: ResourcesManager.GetResourceValue("UpdateFamilyError"));
            }
            familyUpd.Descripcion = family.Descripcion;
            familyUpd.CveTipoFamilia = family.CveTipoFamilia;

            familyRepository.Update(familyUpd);

            var response = await unitOfWork.SaveAsync().ConfigureAwait(false);

            return response == 0 ? new StandardResponse<bool>(HttpStatusCode.BadRequest, false, message: ResourcesManager.GetResourceValue("UpdateFamilyError"))
                   : new StandardResponse<bool>(HttpStatusCode.OK, true, string.Format(ResourcesManager.GetResourceValue("UpdateEmployee"), familyUpd.Descripcion));
        }
    }
}
