using AutoMapper;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Infrastructure.Abstraction.Entities;

namespace TD.Core.Mappers
{
    /// <summary>
    /// Model Mapper Profile
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class SQLEntityMappersProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SQLEntityMappersProfile"/> class.
        /// </summary>
        public SQLEntityMappersProfile()
        {
            // Mappers for entities
            //Employees
            CreateMap<CatEmpleado, EmployeeStylistResponseDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));
            CreateMap<CatEmpleado, EmployeeResponseDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre));
            CreateMap<CatEmpleado, EmployeeRequestDto>().ReverseMap();

            //Customers
            CreateMap<CatCliente, CustomerResponseDto>().ReverseMap();
            CreateMap<CatCliente, CustomerRequestDto>().ReverseMap();

            //Families
            CreateMap<CatFamilia, FamilyResponseDto>().ReverseMap();
            CreateMap<CatFamilia, familyRequestDto>().ReverseMap();

            //Products And Serv
            CreateMap<CatProdServ, ProdAndServResponseDto>().ReverseMap();
            CreateMap<CatProdServ, ProdAndServRequestDto>().ReverseMap();

            //Branches
            CreateMap<CatSucursale, BranchResponseDto>().ReverseMap();
            CreateMap<CatSucursale, BranchRequestDto>().ReverseMap();

            //Franchises
            CreateMap<CatFranquicia, FranchiseResponseDto>().ReverseMap();
            CreateMap<CatFranquicia, FranchiseRequestDto>().ReverseMap();

            //WaitingList
            CreateMap<ListaEspera, WaitingListResponseDto>().ReverseMap();
            CreateMap<ListaEspera, WaitingListRequestDto>().ReverseMap();
        }
    }
}
