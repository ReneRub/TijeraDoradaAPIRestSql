using Tijera.API.Shared.Results;

namespace Tijera.API.Extensios
{
    /// <summary>
    /// Add builders
    /// </summary>
    public static class BuildersExtensions
    {
        /// <summary>
        /// Adds the custom builders.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddCustomBuilders(this IServiceCollection services)
        {
            services.AddTransient<IResponseBuilder, ResponseBuilder>();
        }
    }
}
