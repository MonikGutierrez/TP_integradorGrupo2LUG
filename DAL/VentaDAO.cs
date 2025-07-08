using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Transactions;
using Entity;
using MPP;

namespace DAL
{
    public class VentaDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public void Agregar(Venta venta)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdVenta = new SqlCommand(
                    "INSERT INTO Venta (clienteId, fecha, total, estado, metodoPago) OUTPUT INSERTED.id VALUES (@clienteId, @fecha, @total, @estado, @metodo)", conn);
                cmdVenta.Parameters.AddWithValue("@clienteId", venta.ClienteId);
                cmdVenta.Parameters.AddWithValue("@fecha", venta.Fecha);
                cmdVenta.Parameters.AddWithValue("@total", venta.Total);
                cmdVenta.Parameters.AddWithValue("@estado", venta.Estado);
                cmdVenta.Parameters.AddWithValue("@metodo", venta.MetodoPago);

                int ventaId = (int)cmdVenta.ExecuteScalar();

                foreach (var det in venta.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand(
                        "INSERT INTO DetalleVenta (ventaId, productoId, cantidad, precioUnitario) VALUES (@ventaId, @productoId, @cantidad, @precio)", conn);
                    cmdDet.Parameters.AddWithValue("@ventaId", ventaId);
                    cmdDet.Parameters.AddWithValue("@productoId", det.ProductoId);
                    cmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    cmdDet.Parameters.AddWithValue("@precio", det.PrecioUnitario);
                    cmdDet.ExecuteNonQuery();
                }

                scope.Complete();
            }
        }

        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Venta";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                VentaMapper mapper = new VentaMapper();
                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }
    }
}

