// MPP/ClienteMapper.cs
using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class ClienteMapper
    {
        public Cliente Mapear(SqlDataReader reader)
        {
            return new Cliente
            {
                Id = (int)reader["id"],
                Nombre = reader["nombre"].ToString(),
                Apellido = reader["apellido"].ToString(),
                Email = reader["email"].ToString(),
                Telefono = reader["telefono"].ToString(),
                FechaRegistro = Convert.ToDateTime(reader["fechaRegistro"])
            };
        }
    }
}

