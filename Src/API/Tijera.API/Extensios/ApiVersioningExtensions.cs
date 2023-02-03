using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning.Conventions;

namespace Tijera.API.Extensios
{
    /// <summary>
    /// Add Api Versioning configuration
    /// </summary>
    public static class ApiVersioningExtensions
    {
        /// <summary>
        /// Adds the custom API versioning.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddCustomApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
                options.Conventions.Add(new VersionByNamespaceConvention());
                options.UseApiBehavior = false;

                // This option specifies a deprecated version on a Controller.

                //options.ErrorResponses = new IErrorResponseProvider();

                // This option takes a custom ErrorResponseProvider.

                // options.Conventions.Controller<WeatherForecastController>().HasDeprecatedApiVersion(1, 0);
            });            
        }
    }
}
