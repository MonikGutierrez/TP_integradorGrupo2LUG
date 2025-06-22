using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class StockMapper
    {
        public Stock Mapear(SqlDataReader reader)
        {
            return new Stock
            {
                Id = (int)reader["id"],
                TipoProducto = reader["tipoProducto"].ToString(),
                Descripcion = reader["descripcion"].ToString(),
                Cantidad = Convert.ToInt32(reader["cantidad"])
            };
        }
    }
}