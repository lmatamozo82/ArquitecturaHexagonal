using ArquitecturaHexagonal.Playlist.Dominio.Entidades;
using ArquitecturaHexagonal.Playlist.Dominio.Persistencia;

namespace ArquitecturaHexagonal.Playlist.Aplicacion.CasosUso
{
    public class GetByObjIDDispositivosPlaylistTimestampsUseCase : IGetByObjIDDispositivosPlaylistTimestampsUseCase
    {
        private readonly IDispositivosPlaylistTimestampRepository _repository;

        public GetByObjIDDispositivosPlaylistTimestampsUseCase(IDispositivosPlaylistTimestampRepository repository)
        {
            _repository = repository;
        }

        public Task<DispositivosPlaylistTimestamps> Execute(int objID)
        {
            return _repository.GetByObjID(objID);
        }
    }
}
