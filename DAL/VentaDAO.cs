using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Entity;
using MPP;

namespace DAL
{
    public class VentaDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AtelierSarkany"].ConnectionString;

        public List<Venta> ListarTodo()
        {
            try
            {
                List<Venta> lista = new List<Venta>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Venta";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            VentaMapper ventaMapper = new VentaMapper();
                            return ventaMapper.ListarTodo(reader);
                        }
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Agregar(Venta venta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Venta (clienteId, fecha, total) VALUES (@clienteId, @fecha, @total); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //reviso y le paso si tiene o no clienteId. Si es 0, le paso DBNull.Value
                    if (venta.ClienteId == 0)
                    {
                        cmd.Parameters.AddWithValue("@clienteId", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@clienteId", venta.ClienteId);
                    }
                    cmd.Parameters.AddWithValue("@fecha", venta.FechaVenta);
                    cmd.Parameters.AddWithValue("@total", venta.Total);
                    venta.Id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Eliminar(Venta venta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Venta WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", venta.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Venta ObtenerVentaPorId(int id)
        {
            return null;
        }
        public bool TieneVentasActivasConCalzado(int calzadoId)
        {
            return false;
        }
    }
}