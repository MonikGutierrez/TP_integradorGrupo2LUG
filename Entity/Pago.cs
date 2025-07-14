using System;

namespace Entity
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MedioPago { get; set; } // Efectivo, Tarjeta, etc.
        public int VentaId { get; set; } // ID de la venta asociada al pago

        public Pago()
        {
            Fecha = DateTime.Now; // Fecha actual por defecto
        }


    }
}
