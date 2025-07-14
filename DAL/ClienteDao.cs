using Entity;
using MPP;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class ClienteDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AtelierSarkany"].ConnectionString;

        public List<Cliente> ListarTodo()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Cliente";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ClienteMapper clienteMapper = new ClienteMapper();
                            return clienteMapper.ListarTodo(reader);

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


        public Cliente Listar(Cliente cliente)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Cliente WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", cliente.Id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ClienteMapper clienteMapper = new ClienteMapper();
                            return clienteMapper.Listar(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;

        }


        public void Agregar(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Cliente (nombre, apellido, dni, email, telefono, fechaRegistro) 
                         VALUES (@nombre, @apellido, @dni, @email, @telefono, @fecha)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@dni", cliente.DNI);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@fecha", cliente.FechaRegistro);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Modificar(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Cliente 
                         SET nombre = @nombre, apellido = @apellido, dni = @dni, email = @email, telefono = @telefono 
                         WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@dni", cliente.DNI);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@id", cliente.Id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        public void Eliminar(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Cliente WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", cliente.Id);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {
                throw;

            }

        }



        public bool ExisteDNI(string dni)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Cliente WHERE DNI = @dni";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool ExisteDNIParaOtroCliente(string dni, int clienteId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Cliente WHERE DNI = @dni AND Id != @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool TieneVentasActivas(int clienteId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Venta WHERE ClienteId = @clienteId"; // sin Estado
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        public bool TieneCitasActivas(int clienteId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Cita c INNER JOIN Reserva r ON c.ReservaId = r.Id WHERE r.ClienteId = @clienteId AND c.TipoEstado IN ('Confirmada', 'Pendiente')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);
                    return (int)cmd.ExecuteScalar() > 0;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

