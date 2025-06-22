using System;

namespace Entity
{
    public class Cita
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public DateTime FechaHora { get; set; }
        public string TipoEstado { get; set; } // Pendiente, Confirmada, Cancelada
        public string Observaciones { get; set; }
    }
}