using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Infrastructure.Repositories
{
    /// <summary>
    /// WaitingList Repository
    /// </summary>
    public class WaitingListRepository : Repository<ListaEspera>, IWaitingListRepository
    {
        private readonly ILogger<EmployeeRepository> logger;
        private readonly IMapper mapper;
        private readonly TIJERADORADAContext dbContext;

        public WaitingListRepository(ILogger<EmployeeRepository> logger, IMapper mapper, TIJERADORADAContext dbContext)
            :base(dbContext)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Get WaitingList
        /// </summary>
        /// <param name="franchise"></param>
        /// <param name="branch"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ListaEspera>> GetWaitingList(int franchise, int branch)
        {
            var waitingList = new List<ListaEspera>();

            if (franchise > 0)
            {
                if (branch > 0)
                {
                    waitingList = await Context.Set<ListaEspera>()
                                   .Include(x => x.CveSucursalNavigation)
                                   .ThenInclude(b => b.CveFranquiciaNavigation)
                                   .Where(x => x.CveSucursal == branch && x.CveSucursalNavigation.CveFranquicia == franchise)
                                   .ToListAsync()
                                   .ConfigureAwait(false);
                }
                else
                {
                    waitingList = await Context.Set<ListaEspera>()
                                       .Include(x => x.CveSucursalNavigation)
                                       .ThenInclude(b => b.CveFranquiciaNavigation)
                                       .Where(x => x.CveSucursalNavigation.CveFranquicia == franchise)
                                       .ToListAsync()
                                       .ConfigureAwait(false);
                }

                return waitingList.ToList();
            }

            if (branch > 0)
            {
                waitingList = await Context.Set<ListaEspera>()
               .Where(x => x.CveSucursal == branch)
               .ToListAsync()
               .ConfigureAwait(false);
                
            }

            return waitingList.ToList();
        }
    }
}
