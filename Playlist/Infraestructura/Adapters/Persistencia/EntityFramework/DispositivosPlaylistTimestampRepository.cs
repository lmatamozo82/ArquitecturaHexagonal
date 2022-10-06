using ArquitecturaHexagonal.Playlist.Dominio.Data;
using ArquitecturaHexagonal.Playlist.Dominio.Entidades;
using ArquitecturaHexagonal.Playlist.Dominio.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace ArquitecturaHexagonal.Playlist.Infraestructura.Adapters.Persistencia.EntityFramework
{
    public class DispositivosPlaylistTimestampRepository : IDispositivosPlaylistTimestampRepository
    {
        private readonly DispositivosPlaylistTimestampsContext _context;

        public DispositivosPlaylistTimestampRepository(DispositivosPlaylistTimestampsContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;

        public void Add(DispositivosPlaylistTimestamps dispositivo)
        {
            _context?.DispositivosPLTimestamps?.Add(dispositivo);
        }

        public void Delete(DispositivosPlaylistTimestamps dispositivo)
        {
            _context?.DispositivosPLTimestamps?.Remove(dispositivo);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<List<DispositivosPlaylistTimestamps>> GetAll()
        {
            return await _context?.DispositivosPLTimestamps.ToListAsync();
        }

        public async Task<DispositivosPlaylistTimestamps> GetByCodigo(int codigoId)
        {
            return await _context?.DispositivosPLTimestamps?.AsNoTracking().Where(d => d.Codigo == codigoId).FirstAsync();
        }

        public async Task<DispositivosPlaylistTimestamps> GetByObjID(int objID)
        {
            return await _context?.DispositivosPLTimestamps?.AsNoTracking().Where(d => d.ObjectId == objID).FirstAsync();
        }

        public void Update(DispositivosPlaylistTimestamps dispositivo)
        {
            _context?.DispositivosPLTimestamps?.Update(dispositivo);
        }
    }
}
