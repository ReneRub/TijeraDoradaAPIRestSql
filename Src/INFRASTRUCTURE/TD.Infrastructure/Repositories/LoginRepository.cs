using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Infrastructure.Repositories
{
    /// <summary>
    /// Login Repository
    /// </summary>
    public class LoginRepository : Repository<CatEmpleado>, ILoginRepository
    {
        private readonly ILogger<EmployeeRepository> logger;
        private readonly IMapper mapper;
        private readonly TIJERADORADAContext dbContext;

        public LoginRepository(ILogger<EmployeeRepository> logger, IMapper mapper, TIJERADORADAContext dbContext)
            : base(dbContext)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.dbContext = dbContext; 
        }

        /// <summary>
        /// Get Access Login
        /// </summary>
        /// <param name="Credentials"></param>
        /// <returns></returns>
        public async Task<List<LoginResponseDto>> GetAccessLogin(LoginRequestDto Credentials)
        {
            var data = await dbContext.CatEmpleados
                .Where(cpr => cpr.Usuario == Credentials.UserName && cpr.Password == Credentials.Password && cpr.CveStatusEmpleado == 1 && (cpr.EsEmpleadoActual ?? true))
                .Join(dbContext.CatSucursalesXempleados, cpr => cpr.CveEmpleado, prb => prb.CveEmpleado, (cpr, prb)
                => new { CatEmp = cpr, CatSucX = prb })
                .Join(dbContext.CatSucursales, x => x.CatSucX.CveSucursal, cs => cs.CveSucursal, (x, cs)
                => new LoginResponseDto
                {
                    Name = x.CatEmp.Nombre,
                    Descripcion = cs.Descripcion,
                    CveSucursal = x.CatSucX.CveSucursal,
                    CveEmpleado = x.CatEmp.CveEmpleado,
                    CveTipoEmpleado = x.CatEmp.CveTipoEmpleado
                }).ToListAsync();


            return data;
        }
    }
}
