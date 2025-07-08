using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                Descripcion = reader["descripcion"].ToString(),
                Modelo = reader["modelo"].ToString(),
                Color = reader["color"].ToString(),
                Temporada = reader["temporada"].ToString(),
                Precio = (decimal)reader["precio"],
                Stock = (int)reader["stock"],
                Estado = reader["estado"].ToString(),
                Talle = reader["talle"].ToString(),
                Disenador = reader["disenador"].ToString(),
                FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]),
                FechaUltimaModificacion = Convert.ToDateTime(reader["fechaUltimaModificacion"]),
                TiempoAjusteHoras = Convert.ToInt32(reader["tiempoAjusteHoras"]),
                EsUnico = reader["es_unico"] != DBNull.Value && Convert.ToBoolean(reader["es_unico"]),
                FechaUltimoAjuste = reader["fecha_ultimo_ajuste"] != DBNull.Value ? Convert.ToDateTime(reader["fecha_ultimo_ajuste"]) : (DateTime?)null
            };
        }
    }
}