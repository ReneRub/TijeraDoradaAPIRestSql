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
    /// Class EmployeeRepository
    /// </summary>
    public class EmployeeRepository : Repository<CatEmpleado>, IEmployeeRepository
    {
        private readonly ILogger<EmployeeRepository> logger;
        private readonly IMapper mapper;
        private readonly TIJERADORADAContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRepository"/> class.
        /// </summary>
        /// <param name="context">The db context</param>
        public EmployeeRepository(TIJERADORADAContext context, ILogger<EmployeeRepository> logger, IMapper mapper)
            : base(context)
        {
            this.dbContext = context;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CatEmpleado>> GetStylist(int sucursal)
        {
            var data = await Context.Set<CatEmpleado>()
            .Where(x => x.CveSucursal == sucursal && x.CveTipoEmpleado == 3 && x.Disponibilidad == "S" && (x.EsEmpleadoActual ?? true))
            .ToListAsync()
            .ConfigureAwait(false);

            return data.ToList();
        }

        public async Task<IEnumerable<CatEmpleado>> GetEmployees()
        {
            var data = await Context.Set<CatEmpleado>()
            //.Include(x => x.TipoEmpleado)
            //.Include(x => x.Sucursal)
            //.Include(x => x.Status)
            .ToListAsync()
            .ConfigureAwait(false);

            return data.ToList();
        }

        public async Task<List<EmployeeStylistResponseDto>> GetAccessLogin(LoginRequestDto Credentials)
        {
            var data = await dbContext.CatEmpleados
                .Where(cpr => cpr.Usuario == Credentials.UserName && cpr.Password == Credentials.Password  && cpr.CveStatusEmpleado == 1 && (cpr.EsEmpleadoActual ?? true))
                .Join(dbContext.CatSucursalesXempleados, cpr => cpr.CveEmpleado, prb => prb.CveEmpleado, (cpr, prb)
                => new { CatEmp = cpr, CatSucX = prb })
                .Join(dbContext.CatSucursales, x => x.CatSucX.CveSucursal, cs => cs.CveSucursal, (x, cs)
                => new EmployeeStylistResponseDto
                {
                    Name = x.CatEmp.Nombre,
                    Descripcion = cs.Descripcion,
                    CveSucursal = x.CatSucX.CveSucursal,
                    CveEmpleado = x.CatEmp.CveEmpleado,
                    CveTipoEmpleado = x.CatEmp.CveTipoEmpleado
                }).ToListAsync();


            return data;
        }

        public async Task<CatEmpleado> GetEmployee(int id)
        {
            var result =  await Context.Set<CatEmpleado>()
            .AsNoTracking()
            .Where(x => x.CveEmpleado == id)
            .FirstOrDefaultAsync()
            .ConfigureAwait(false);

            return result;
        }
    }
}
