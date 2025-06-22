using System;

namespace Entity
{
    public class Pago
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; } // Efectivo, Tarjeta, etc.
        public string Observaciones { get; set; }
        public int ReservaId { get; set; }

    }
}
