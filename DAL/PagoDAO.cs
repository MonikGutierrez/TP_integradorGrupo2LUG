using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;
using MPP;

namespace DAL
{
    public class PagoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AtelierSarkany"].ConnectionString;

        public void Agregar(Pago pago)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Pago (monto, fecha, medioPago, ventaId) VALUES (@monto, @fecha, @medioPago, @ventaId)", conn);

                    cmd.Parameters.AddWithValue("@monto", pago.Monto);
                    cmd.Parameters.AddWithValue("@fecha", pago.Fecha);
                    cmd.Parameters.AddWithValue("@medioPago", pago.MedioPago);
                    cmd.Parameters.AddWithValue("@ventaId", pago.VentaId);


                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }



        public void Eliminar(Pago pago)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Pago WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", pago.Id);

                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Pago> ListarTodo()
        {
            try
            {
                List<Pago> lista = new List<Pago>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Pago";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            PagoMapper pagoMapper = new PagoMapper();
                            return pagoMapper.ListarTodo(reader);

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