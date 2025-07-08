using System;

namespace Entity
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VestidoId { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public decimal MontoReservado { get; set; }
        public string Estado { get; set; }
        public Cliente Cliente { get; set; }  


        public bool Expirado => DateTime.Now > FechaExpiracion;

        public override string ToString()
        {
            return $"Reserva #{Id} - Cliente {ClienteId} - Vestido {VestidoId}";
        }
    }
}
