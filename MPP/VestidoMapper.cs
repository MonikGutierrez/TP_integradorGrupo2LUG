using System;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class VestidoMapper
    {
        public Vestido Mapear(SqlDataReader reader)
        {
            return new Vestido
            {
                Id = (int)reader["id"],
                Nombre = reader["nombre"].ToString(),
                Estado = reader["estado"].ToString(),
                Talle = reader["talle"].ToString(),
                Disenador = reader["disenador"].ToString(),
                TiempoAjusteHoras = Convert.ToInt32(reader["tiempoAjusteHoras"]),
                EsUnico = reader["es_unico"] != DBNull.Value && Convert.ToBoolean(reader["es_unico"]),
                FechaUltimoAjuste = reader["fecha_ultimo_ajuste"] != DBNull.Value ? Convert.ToDateTime(reader["fecha_ultimo_ajuste"]) : (DateTime?)null
            };
        }
    }
}