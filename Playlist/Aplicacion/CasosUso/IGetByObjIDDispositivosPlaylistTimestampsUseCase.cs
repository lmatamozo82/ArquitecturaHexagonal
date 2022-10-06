using ArquitecturaHexagonal.Playlist.Dominio.Entidades;

namespace ArquitecturaHexagonal.Playlist.Aplicacion.CasosUso
{
    public interface IGetByObjIDDispositivosPlaylistTimestampsUseCase
    {
        Task<DispositivosPlaylistTimestamps> Execute(int objID);
    }
}
