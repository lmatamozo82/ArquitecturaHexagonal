using ArquitecturaHexagonal.Playlist.Dominio.Entidades;
using ArquitecturaHexagonal.Playlist.Dominio.Persistencia;
using Microsoft.Extensions.Logging;

namespace ArquitecturaHexagonal.Playlist.Aplicacion.CasosUso
{
    public class GetAllDispositivosPlaylistTimestampsUseCase : IGetAllDispositivosPlaylistTimestamosUseCase
    {
        private readonly IDispositivosPlaylistTimestampRepository _repository;

        public GetAllDispositivosPlaylistTimestampsUseCase(IDispositivosPlaylistTimestampRepository repository)
        {
            _repository = repository;
        }

        public Task<List<DispositivosPlaylistTimestamps>> Execute()
        {
            return _repository.GetAll();
        }

    }
}
