using AutoMapper;
using TD.Core.Mappers;

namespace Tijera.API.Extensios
{
    /// <summary>
    /// Mapper extensions
    /// </summary>
    public static class MapperExtensions
    {
        /// <summary>
        /// Adds the custom automatic mapper.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddCustomAutoMapper(this IServiceCollection services)
        {
            var profiles = new Profile[]
            {
                new SQLEntityMappersProfile(),
            };

            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfiles(profiles);
                config.AllowNullDestinationValues = true;
                config.AllowNullCollections = false;
            });
            mapperConfig.CompileMappings();
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
