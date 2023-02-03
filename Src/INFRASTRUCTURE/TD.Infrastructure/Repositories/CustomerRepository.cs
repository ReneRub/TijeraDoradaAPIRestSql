using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TD.Infrastructure.Abstraction.Entities;
using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Infrastructure.Repositories
{
    /// <summary>
    /// Class CustomerRepository
    /// </summary>
    public class CustomerRepository : Repository<CatCliente>, ICustomerRepository
    {
        private readonly ILogger<CustomerRepository> logger;
        private readonly IMapper mapper;
        private readonly TIJERADORADAContext dbContext;

        public CustomerRepository(ILogger<CustomerRepository> logger, IMapper mapper, TIJERADORADAContext dbContext)
            : base(dbContext)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.dbContext = dbContext; 
        }

        public async Task<IEnumerable<CatCliente>> GetCustomers(string FirstName, string SurNAme, string LastName)
        {
            var data = await Context.Set<CatCliente>()
            .ToListAsync()
            .ConfigureAwait(false);

            return data.ToList();
        }

    }
}
