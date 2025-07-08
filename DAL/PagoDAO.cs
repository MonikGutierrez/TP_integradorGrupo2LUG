using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;
using MPP;

namespace DAL
{
    public class PagoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public void Agregar(Pago pago)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Pago (clienteId, monto, fechaPago, metodoPago, observaciones) VALUES (@clienteId, @monto, @fechaPago, @metodoPago, @observaciones)", conn);

                cmd.Parameters.AddWithValue("@clienteId", pago.ClienteId);
                cmd.Parameters.AddWithValue("@monto", pago.Monto);
                cmd.Parameters.AddWithValue("@fechaPago", pago.FechaPago);
                cmd.Parameters.AddWithValue("@metodoPago", pago.MetodoPago);
                cmd.Parameters.AddWithValue("@observaciones", pago.Observaciones);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Pago> Listar()
        {
            List<Pago> lista = new List<Pago>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pago", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                PagoMapper mapper = new PagoMapper();
                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }
    }
}