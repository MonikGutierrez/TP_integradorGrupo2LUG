using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;
using MPP;

namespace DAL
{
    public class CitaDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AtelierSarkany"].ConnectionString;

        public List<Cita> ListarTodo()
        {
            try
            {
                List<Cita> lista = new List<Cita>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Cita";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            CitaMapper citaMapper = new CitaMapper();
                            return citaMapper.ListarTodo(reader);

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



        public void Agregar(Cita cita)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Cita (clienteId, fechaHora, tipoEstado, observaciones) VALUES (@clienteId, @fechaHora, @tipoEstado, @observaciones)", conn);

                    cmd.Parameters.AddWithValue("@clienteId", cita.ClienteId);
                    cmd.Parameters.AddWithValue("@fechaHora", cita.FechaHora);
                    cmd.Parameters.AddWithValue("@tipoEstado", cita.TipoEstado);
                    cmd.Parameters.AddWithValue("@observaciones", cita.Observaciones);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;

            }

        }


        public void Modificar(Cita cita)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"UPDATE Cita SET  clienteId = @clienteId, fechaHora = @fechaHora, tipoEstado = @tipoEstado, observaciones = @observaciones WHERE id = @id", conn);

                    cmd.Parameters.AddWithValue("@Id", cita.Id);
                    cmd.Parameters.AddWithValue("@clienteId", cita.ClienteId);
                    cmd.Parameters.AddWithValue("@fechaHora", cita.FechaHora);
                    cmd.Parameters.AddWithValue("@tipoEstado", cita.TipoEstado);
                    cmd.Parameters.AddWithValue("@observaciones", cita.Observaciones ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;

            }

        }

        public void Eliminar(Cita cita)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var scope = new System.Transactions.TransactionScope())
                    {
                        string query = "DELETE FROM Cita WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", cita.Id);
                            cmd.ExecuteNonQuery();
                        }
                        scope.Complete();
                    }
                }
            }
            catch (Exception)
            {
                throw;

            }


        }

    }
}
