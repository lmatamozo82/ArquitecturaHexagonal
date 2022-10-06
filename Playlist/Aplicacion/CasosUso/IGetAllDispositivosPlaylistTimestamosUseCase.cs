using ArquitecturaHexagonal.Playlist.Dominio.Entidades;

namespace ArquitecturaHexagonal.Playlist.Aplicacion.CasosUso
{
    public interface IGetAllDispositivosPlaylistTimestamosUseCase
    {
        Task<List<DispositivosPlaylistTimestamps>> Execute();
    }
}
