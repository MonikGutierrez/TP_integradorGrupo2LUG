using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace MPP
{
    public class VentaMapper
    {
        public Venta Mapear(SqlDataReader reader)
        {
            return new Venta
            {
                Id = (int)reader["id"],
                ClienteId = (int)reader["clienteId"],
                Fecha = Convert.ToDateTime(reader["fecha"]),
                Total = (decimal)reader["total"],
                Estado = reader["estado"].ToString(),
                MetodoPago = reader["metodoPago"].ToString()
            };
        }
    }
}
