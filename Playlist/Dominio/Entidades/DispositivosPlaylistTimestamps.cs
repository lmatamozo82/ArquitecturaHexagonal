using ArquitecturaHexagonal.Playlist.Dominio.Entidades.Base;
using System.ComponentModel.DataAnnotations;

namespace ArquitecturaHexagonal.Playlist.Dominio.Entidades
{
    public class DispositivosPlaylistTimestamps : Entity, IAggregateRoot
    { 
        [Required]
        public int ObjectId { get; set; }
        public DateTime? Local_Playlist { get; set; }
        public DateTime? Remote_Playlist { get; set; }
        public DateTime? LastRequest { get; set; }
        public int Forced { get; set; }
        public int Updated { get; set; }
        public int? Empresa { get; set; }
        public sbyte? TipoPeticion { get; set; }
        public int? RecursosTotales { get; set; }
        public int? RecursosPendientes { get; set; }
        public sbyte Configured { get; set; }
        public DateTime? DeviceConfigDate { get; set; }
        public sbyte? DenevaMirrorEmitiendo { get; set; }
        public DateTime? DenevaMirrorEmitiendoVigencia { get; set; }
    }
}
