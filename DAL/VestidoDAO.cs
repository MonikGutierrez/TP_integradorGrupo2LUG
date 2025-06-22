using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Transactions;
using Entity;
using MPP;

namespace DAL
{
    public class VestidoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public List<Vestido> Listar()
        {
            List<Vestido> lista = new List<Vestido>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vestido", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                VestidoMapper mapper = new VestidoMapper();
                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }

        public void Agregar(Vestido vestido)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Vestido (nombre, estado, talle, disenador, tiempoAjusteHoras, es_unico, fecha_ultimo_ajuste)
                                 VALUES (@nombre, @estado, @talle, @disenador, @tiempo, @esUnico, @fecha)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", vestido.Nombre);
                cmd.Parameters.AddWithValue("@estado", vestido.Estado);
                cmd.Parameters.AddWithValue("@talle", vestido.Talle);
                cmd.Parameters.AddWithValue("@disenador", vestido.Disenador);
                cmd.Parameters.AddWithValue("@tiempo", vestido.TiempoAjusteHoras);
                cmd.Parameters.AddWithValue("@esUnico", vestido.EsUnico);
                cmd.Parameters.AddWithValue("@fecha", (object)vestido.FechaUltimoAjuste ?? DBNull.Value);
                cmd.ExecuteNonQuery();
                scope.Complete();
            }
        }

        public void Modificar(Vestido vestido)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Vestido SET 
                                    nombre = @nombre, 
                                    estado = @estado, 
                                    talle = @talle, 
                                    disenador = @disenador, 
                                    tiempoAjusteHoras = @tiempo, 
                                    es_unico = @esUnico, 
                                    fecha_ultimo_ajuste = @fecha
                                 WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", vestido.Nombre);
                cmd.Parameters.AddWithValue("@estado", vestido.Estado);
                cmd.Parameters.AddWithValue("@talle", vestido.Talle);
                cmd.Parameters.AddWithValue("@disenador", vestido.Disenador);
                cmd.Parameters.AddWithValue("@tiempo", vestido.TiempoAjusteHoras);
                cmd.Parameters.AddWithValue("@esUnico", vestido.EsUnico);
                cmd.Parameters.AddWithValue("@fecha", (object)vestido.FechaUltimoAjuste ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", vestido.Id);
                cmd.ExecuteNonQuery();
                scope.Complete();
            }
        }

        public void Eliminar(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Vestido WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                scope.Complete();
            }
        }
    }
}