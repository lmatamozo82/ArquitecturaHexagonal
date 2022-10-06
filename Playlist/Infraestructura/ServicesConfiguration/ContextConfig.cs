using ArquitecturaHexagonal.Playlist.Infraestructura.Adapters.Persistencia.DatabaseFlavor;
using ArquitecturaHexagonal.Playlist.Infraestructura.Adapters.Persistencia.EntityFramework;

namespace ArquitecturaHexagonal.Playlist.Infraestructura.ServicesConfiguration
{
    public static class ContextConfig
    {
        public static void AddContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureProviderForContext<DispositivosPlaylistTimestampsContext>(ProviderConfiguration.DetectDatabase(configuration));
        }
    }
}
