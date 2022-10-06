using ArquitecturaHexagonal.Playlist.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace TArquitecturaHexagonal.Playlist.Infraestructura.Adapters.Persistencia.EntityFramework.Configuraciones
{
    public class DispositivosPlaylistTimestampsConfig : IEntityTypeConfiguration<DispositivosPlaylistTimestamps>
    {
        public void Configure(EntityTypeBuilder<DispositivosPlaylistTimestamps> builder)
        {
            builder.HasKey(x => x.Codigo);

        }
    }
}
