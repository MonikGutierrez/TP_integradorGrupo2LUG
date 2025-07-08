using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;
using MPP;

namespace DAL
{
    public class StockDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public void Agregar(Stock stock)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ControlStock (tipoProducto, descripcion, cantidad) VALUES (@tipo, @desc, @cant)", conn);

                cmd.Parameters.AddWithValue("@tipo", stock.TipoProducto);
                cmd.Parameters.AddWithValue("@desc", stock.Descripcion);
                cmd.Parameters.AddWithValue("@cant", stock.Cantidad);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Stock> Listar()
        {
            List<Stock> lista = new List<Stock>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ControlStock", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                StockMapper mapper = new StockMapper();
                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }
    }
}