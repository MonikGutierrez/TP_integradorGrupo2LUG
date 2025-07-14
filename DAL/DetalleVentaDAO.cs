using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleVentaDao
    {
        private string connectionString;

        public DetalleVentaDao()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AtelierSarkany"].ConnectionString;
        }

        public List<DetalleVenta> ListarPorVentaId(int ventaId)
        {

            var lista = new List<DetalleVenta>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM DetalleVenta WHERE VentaId = @VentaId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VentaId", ventaId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var detalle = new DetalleVenta
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    VentaId = Convert.ToInt32(reader["VentaId"]),
                                    ProductoId = Convert.ToInt32(reader["ProductoId"]),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                    PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                                };

                                lista.Add(detalle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los detalles de la venta: " + ex.Message);
            }

            return lista;
        }


        public void Agregar(DetalleVenta detalle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO DetalleVenta 
                                    (ventaId, productoId, cantidad, precioUnitario)
                                     VALUES 
                                    (@ventaId, @productoId, @cantidad, @precioUnitario); SELECT SCOPE_IDENTITY()";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ventaId", detalle.VentaId);
                        cmd.Parameters.AddWithValue("@productoId", detalle.ProductoId);
                        cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmd.Parameters.AddWithValue("@precioUnitario", detalle.PrecioUnitario);

                        conn.Open();
                        detalle.Id = Convert.ToInt32(cmd.ExecuteScalar()); //hago un escalar para que me devuelva el ID del detalle insertado
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el detalle de venta: " + ex.Message);
            }
        }

        public List<DetalleVenta> ListarPorVenta(int ventaId)
        {
            try
            {
                var lista = new List<DetalleVenta>();
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM DetalleVenta WHERE VentaId=@VentaId", conn);
                    cmd.Parameters.AddWithValue("@VentaId", ventaId);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new DetalleVenta
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            VentaId = ventaId,
                            ProductoId = Convert.ToInt32(reader["ProductoId"]),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                            producto = new ProductoDAO().Listar(new Vestido
                            {
                                Id = Convert.ToInt32(reader["ProductoId"])
                            })
                        });
                    }
                }
                return lista;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Eliminar(int id)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM DetallesVenta WHERE Id=@Id", conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<DetalleVenta> ObtenerPorVentaId(int ventaId)
        {
            try
            {
                var lista = new List<DetalleVenta>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM DetalleVenta WHERE VentaId = @VentaId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VentaId", ventaId);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var detalle = new DetalleVenta
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    VentaId = Convert.ToInt32(reader["VentaId"]),
                                    ProductoId = Convert.ToInt32(reader["ProductoId"]),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                    PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                                };
                                lista.Add(detalle);
                            }
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

    }
}
