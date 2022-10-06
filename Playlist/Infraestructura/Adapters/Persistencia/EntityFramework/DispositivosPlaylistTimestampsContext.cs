using ArquitecturaHexagonal.Playlist.Dominio.Data;
using ArquitecturaHexagonal.Playlist.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Reflection;



namespace ArquitecturaHexagonal.Playlist.Infraestructura.Adapters.Persistencia.EntityFramework
{
    public class DispositivosPlaylistTimestampsContext : DbContext, IUnitOfWork
    {
        
        public DispositivosPlaylistTimestampsContext(DbContextOptions<DispositivosPlaylistTimestampsContext> options):base(options){}

        public DbSet<DispositivosPlaylistTimestamps> DispositivosPLTimestamps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //LMM, mapeo de tablas a entidades
            modelBuilder.Entity<DispositivosPlaylistTimestamps>().ToTable("dispositivos_playlist_timestamps");



            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
