using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class CitaMapper
    {
        public Cita Mapear(SqlDataReader reader)
        {
            return new Cita
            {
                Id = (int)reader["id"],
                ReservaId = (int)reader["reservaId"],
                FechaHora = Convert.ToDateTime(reader["fechaHora"]),
                TipoEstado = reader["tipoEstado"].ToString(),
                Observaciones = reader["observaciones"].ToString()
            };
        }
    }
}
