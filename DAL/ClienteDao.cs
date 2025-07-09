using Entity;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using MPP;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace DAL {
    public class ClienteDAO {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public List<Cliente> Listar() {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string query = "SELECT * FROM Cliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                ClienteMapper mapper = new ClienteMapper();
                while (reader.Read()) {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }

        public void Agregar(Cliente cliente) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string query = "INSERT INTO Cliente (nombre, apellido, dni, email, telefono, fechaRegistro) VALUES (@nombre, @apellido, @dni, @email, @telefono, @fecha)";
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
        public void Modificar(Cliente cliente) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string query = "UPDATE Cliente SET nombre = @nombre, apellido = @apellido, dni = @dni, email = @email, telefono = @telefono WHERE id = @id";
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

        public void Eliminar(int id) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string query = "DELETE FROM Cliente WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public Cliente? ObtenerPorDni(String dni) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                string query = "SELECT * FROM Cliente WHERE dni = @dni";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataReader reader = cmd.ExecuteReader();

                ClienteMapper mapper = new ClienteMapper();
                if (reader.Read()) {
                    return mapper.Mapear(reader);
                } else {
                    return null;
                }
            }
        }
    }
}

