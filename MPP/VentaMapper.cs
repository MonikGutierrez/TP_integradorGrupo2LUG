using Entity;
using Microsoft.Data.SqlClient;

namespace MPP
{
    public class VentaMapper
    {
        public List<Venta> ListarTodo(SqlDataReader reader)
        {
            try
            {
                List<Venta> lista = new List<Venta>();

                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.Id = Convert.ToInt32(reader["id"]);
                    venta.FechaVenta = Convert.ToDateTime(reader["fecha"]);
                    venta.ClienteId = reader["clienteId"] != DBNull.Value ? Convert.ToInt32(reader["clienteId"]) : 0;
                    venta.Total = Convert.ToDecimal(reader["total"]);
                    //Detalles = new List<DetalleVenta>(;

                    lista.Add(venta);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mapear venta: " + ex.Message);
            }
        }


    }
}