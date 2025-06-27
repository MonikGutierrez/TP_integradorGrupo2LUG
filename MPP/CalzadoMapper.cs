using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class CalzadoMapper
    {
        public Calzado Mapear(SqlDataReader reader)
        {
            return new Calzado
            {
                Id = (int)reader["id"],
                Nombre = reader["nombre"].ToString(),
                Descripcion = reader["descripcion"].ToString(),
                Modelo = reader["modelo"].ToString(),
                Color = reader["color"].ToString(),
                Temporada = reader["temporada"].ToString(),
                Precio = (decimal)reader["precio"],
                Stock = (int)reader["stock"],
                FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]),
                FechaUltimaModificacion = Convert.ToDateTime(reader["fechaUltimaModificacion"]),
                Numero = Convert.ToDecimal(reader["numero"]),
                Categoria = reader["categoria"].ToString(),
                StockMinimo = (int)reader["stockMinimo"]
            };
        }
    }
}