using Entity;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace MPP
{
    public class VestidoMapper
    {
        public Vestido Mapear(SqlDataReader reader)
        {
            return new Vestido
            {
                Id = (int)reader["id"],
                TipoProducto = reader["tipoProducto"].ToString(),
                Nombre = reader["nombre"].ToString(),
                Descripcion = reader["descripcion"].ToString(),
                Modelo = reader["modelo"].ToString(),
                Color = reader["color"].ToString(),
                Temporada = reader["temporada"].ToString(),
                Precio = (decimal)reader["precio"],
                Stock = (int)reader["stock"],
                FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]),
                FechaUltimaModificacion = Convert.ToDateTime(reader["fechaUltimaModificacion"]),
                Talle = reader["talle"].ToString(),
                Disenador = reader["disenador"].ToString(),
                Estado = reader["estado"].ToString(),
                TiempoAjusteHoras = (int)reader["tiempoAjusteHoras"]
            };
        }
    }
}
