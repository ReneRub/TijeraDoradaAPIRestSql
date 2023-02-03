using AutoMapper;
using Microsoft.Extensions.Logging;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Infrastructure.Repositories
{
    /// <summary>
    /// Class FranchiseRepository
    /// </summary>
    public class FranchiseRepository : Repository<CatFranquicia>, IFranchiseRepository
    {
        private readonly ILogger<EmployeeRepository> logger;
        private readonly IMapper mapper;
        private readonly TIJERADORADAContext dbContext;

        public FranchiseRepository(ILogger<EmployeeRepository> logger, IMapper mapper, TIJERADORADAContext dbContext)
            :base(dbContext)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.dbContext = dbContext;
        }
    }
}
