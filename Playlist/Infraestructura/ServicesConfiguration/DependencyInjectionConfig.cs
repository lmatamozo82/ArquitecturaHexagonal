using ArquitecturaHexagonal.Playlist.Aplicacion.CasosUso;
using ArquitecturaHexagonal.Playlist.Dominio.Persistencia;
using ArquitecturaHexagonal.Playlist.Infraestructura.Adapters.Persistencia.EntityFramework;

namespace ArquitecturaHexagonal.Playlist.Infraestructura.ServicesConfiguration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IDispositivosPlaylistTimestampRepository,DispositivosPlaylistTimestampRepository>();
            services.AddScoped<IGetAllDispositivosPlaylistTimestamosUseCase, GetAllDispositivosPlaylistTimestampsUseCase>();
            services.AddScoped<IGetByObjIDDispositivosPlaylistTimestampsUseCase, GetByObjIDDispositivosPlaylistTimestampsUseCase>();
        }
    }
}
