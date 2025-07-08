using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class PagoMapper
    {
        public Pago Mapear(SqlDataReader reader)
        {
            return new Pago
            {
                Id = (int)reader["id"],
                ClienteId = (int)reader["clienteId"],
                Monto = Convert.ToDecimal(reader["monto"]),
                FechaPago = Convert.ToDateTime(reader["fechaPago"]),
                MetodoPago = reader["metodoPago"].ToString(),
                Observaciones = reader["observaciones"].ToString()
            };
        }
    }
}