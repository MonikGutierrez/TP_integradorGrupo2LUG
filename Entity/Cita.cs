using System;

namespace Entity
{
    public class Cita
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaHora { get; set; }
        public string TipoEstado { get; set; } // Pendiente, Confirmada, Cancelada
        public string Observaciones { get; set; }


    }
}