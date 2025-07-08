using System;

namespace Entity
{
    public class Pago
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } //va un objeto o un id? - puede ser null
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; } // Efectivo, Tarjeta, etc.

        //public string TipoPago { get; set; } //venta o reserva
        public string Observaciones { get; set; }
        public int ReservaId { get; set; } //va un objeto o un id?

    }
}
