using ArquitecturaHexagonal.Playlist.Aplicacion.CasosUso;
using ArquitecturaHexagonal.Playlist.Dominio.Data;
using Microsoft.AspNetCore.Mvc;

namespace ArquitecturaHexagonal.Playlist.Infraestructura.Controllers
{
    [ApiController]
    [Route("api/Playlist")]
    public class DispositivosPlaylistTimestampsController : ControllerBase
    {
        private readonly IGetAllDispositivosPlaylistTimestamosUseCase _getAllDispositivosPlaylistTimestampsUseCase;
        private readonly IGetByObjIDDispositivosPlaylistTimestampsUseCase _getByObjIDDispositivosPlaylistTimestampsUseCase;

        public DispositivosPlaylistTimestampsController(IGetAllDispositivosPlaylistTimestamosUseCase getAllDispositivosPlaylistTimestampsUseCase,
            IGetByObjIDDispositivosPlaylistTimestampsUseCase getByObjIDDispositivosPlaylistTimestampsUseCase)
        {
            if (getAllDispositivosPlaylistTimestampsUseCase == null) throw new ArgumentNullException(nameof(getAllDispositivosPlaylistTimestampsUseCase));
            if (getByObjIDDispositivosPlaylistTimestampsUseCase == null) throw new ArgumentNullException(nameof(getByObjIDDispositivosPlaylistTimestampsUseCase));

            _getAllDispositivosPlaylistTimestampsUseCase = getAllDispositivosPlaylistTimestampsUseCase;
            _getByObjIDDispositivosPlaylistTimestampsUseCase = getByObjIDDispositivosPlaylistTimestampsUseCase;
        }

        [HttpGet("GetAllDispositivos")]
        public async Task<ActionResult> GetAllDispositivos()
        {
            var devices = await _getAllDispositivosPlaylistTimestampsUseCase.Execute();
            return Ok(devices);
        }

        [HttpGet("GetByObjID/{objID:int}")]
        public async Task<ActionResult> GetByObjID(int objID)
        {
            var devices = await _getByObjIDDispositivosPlaylistTimestampsUseCase.Execute(objID);
            return Ok(devices);
        }

    }
}
