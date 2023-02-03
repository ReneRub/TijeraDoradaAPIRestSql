using AutoMapper;
using Microsoft.Extensions.Logging;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Infrastructure.Repositories
{
    /// <summary>
    /// Class BranchRepository
    /// </summary>
    public class BranchRepository : Repository<CatSucursale>, IBranchRepository
    {
        private readonly ILogger<EmployeeRepository> logger;
        private readonly IMapper mapper;
        private readonly TIJERADORADAContext dbContext;

        public BranchRepository(ILogger<EmployeeRepository> logger, IMapper mapper, TIJERADORADAContext dbContext)
            :base(dbContext)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.dbContext = dbContext; 
        }
    }
}
