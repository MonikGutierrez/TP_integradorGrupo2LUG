using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class DetalleVentaMapper
    {
        public DetalleVenta Listar(SqlDataReader reader)
        {
            try
            {
                return new DetalleVenta
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    VentaId = Convert.ToInt32(reader["VentaId"]),
                    ProductoId = Convert.ToInt32(reader["ProductoId"]),
                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                    PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                    // Subtotal es calculado en la propiedad de la clase
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mapear Detalle de Venta: " + ex.Message);
            }
        }
    }
}
