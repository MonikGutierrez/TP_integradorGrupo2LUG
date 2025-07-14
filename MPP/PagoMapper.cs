using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class PagoMapper
    {
        public List<Pago> ListarTodo(SqlDataReader reader)
        {
            try
            {
                List<Pago> lista = new List<Pago>();

                while (reader.Read())
                {
                    Pago pago = new Pago
                    {
                        Id = (int)reader["id"],
                        Monto = Convert.ToDecimal(reader["monto"]),
                        Fecha = Convert.ToDateTime(reader["fecha"]),
                        MedioPago = reader["medioPago"].ToString(),
                        VentaId = Convert.ToInt32(reader["ventaId"])

                    };
                    lista.Add(pago);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}