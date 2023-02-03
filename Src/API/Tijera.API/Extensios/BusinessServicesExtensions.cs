using TD.Core.Abstraction.Services;
using TD.Core.Services;

namespace Tijera.API.Extensios
{
    /// <summary>
    /// Add builders
    /// </summary>
    public static class BusinessServicesExtensions
    {
        /// <summary>
        /// Adds the business services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddBusinessServices(this IServiceCollection services)
        {
            //services.AddScoped
            //services.AddSingleton
            services.AddTransient<IWaitingListService, WaitingListService>();
            services.AddTransient<IFranchiseService, FranchiseService>();
            services.AddTransient<IBranchService, BranchService>();
            services.AddTransient<IFamilyService, FamilyService>();
            services.AddTransient<IProductAndServicesService, ProductAndServicesService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ILoginService, LoginService>();
        }
    }
}
