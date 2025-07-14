using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class CitaMapper
    {
        public List<Cita> ListarTodo(SqlDataReader reader)
        {
            try
            {
                List<Cita> lista = new List<Cita>();

                while (reader.Read())
                {
                    Cita cita = new Cita();
                    cita.Id = Convert.ToInt32(reader["id"]);
                    cita.ClienteId = Convert.ToInt32(reader["ClienteId"]);
                    cita.FechaHora = Convert.ToDateTime(reader["fechaHora"]);
                    cita.ClienteId = reader["clienteId"] != DBNull.Value ? Convert.ToInt32(reader["clienteId"]) : 0;
                    cita.TipoEstado = Convert.ToString(reader["tipoEstado"]);
                    cita.Observaciones = Convert.ToString(reader["observaciones"]);


                    lista.Add(cita);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mapear la cita: " + ex.Message);
            }
        }


    }
}
