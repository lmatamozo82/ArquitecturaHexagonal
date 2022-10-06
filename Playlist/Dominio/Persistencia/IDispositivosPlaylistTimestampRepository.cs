using ArquitecturaHexagonal.Playlist.Dominio.Data;
using ArquitecturaHexagonal.Playlist.Dominio.Entidades;

namespace ArquitecturaHexagonal.Playlist.Dominio.Persistencia
{
    public interface IDispositivosPlaylistTimestampRepository : IRepository<DispositivosPlaylistTimestamps>
    {
        Task<List<DispositivosPlaylistTimestamps>> GetAll();
        Task<DispositivosPlaylistTimestamps> GetByCodigo(int codigoId);

        Task<DispositivosPlaylistTimestamps> GetByObjID(int objID);

        void Add(DispositivosPlaylistTimestamps dispositivo);
        void Update(DispositivosPlaylistTimestamps dispositivo);
        void Delete(DispositivosPlaylistTimestamps dispositivo);
    }
}
