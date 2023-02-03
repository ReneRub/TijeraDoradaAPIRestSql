using TD.Infrastructure.Abstraction.Repositories;
using TD.Infrastructure.Abstraction.UnitOfWork;
using TD.Infrastructure.Repositories;
using TD.Infrastructure.UnitOfWork;

namespace Tijera.API.Extensios
{
    public static class RepositoryExtensions
    {
        /// <summary>
        /// Adds the repositories to services colletion
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IWaitingListRepository, WaitingListRepository>();
            services.AddTransient<IFranchiseRepository, FranchiseRepository>();
            services.AddTransient<IBranchRepository, BranchRepository>();
            services.AddTransient<IFamilyRepository, FamilyRepository>();
            services.AddTransient<IProductAndServicesRepository, ProductAndServicesRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<ILoginRepository, LoginRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
