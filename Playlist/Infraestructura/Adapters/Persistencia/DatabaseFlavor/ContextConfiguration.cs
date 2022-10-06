using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ArquitecturaHexagonal.Playlist.Infraestructura.Adapters.Persistencia.DatabaseFlavor;

/// <summary>
/// SqlServer configuration
/// </summary>
public static class ContextConfiguration
{


    public static IServiceCollection PersistStore<TContext>(this IServiceCollection services, Action<DbContextOptionsBuilder> databaseConfig) where TContext : DbContext
    {
        
        if (services.All(x => x.ServiceType != typeof(TContext)))
            services.AddDbContext<TContext>(databaseConfig);
        return services;
    }


}