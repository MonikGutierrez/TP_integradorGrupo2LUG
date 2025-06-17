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
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public void Agregar(Cita cita)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Cita (reservaId, fechaHora, tipoEstado, observaciones) VALUES (@reservaId, @fechaHora, @tipoEstado, @observaciones)", conn);

                cmd.Parameters.AddWithValue("@reservaId", cita.ReservaId);
                cmd.Parameters.AddWithValue("@fechaHora", cita.FechaHora);
                cmd.Parameters.AddWithValue("@tipoEstado", cita.TipoEstado);
                cmd.Parameters.AddWithValue("@observaciones", cita.Observaciones);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Cita> Listar()
        {
            List<Cita> lista = new List<Cita>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cita", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                CitaMapper mapper = new CitaMapper();
                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }
    }
}
