using System;
using Microsoft.Data.SqlClient;

using Entity;

namespace MPP
{
    public class ClienteMapper
    {
        public List<Cliente> ListarTodo(SqlDataReader reader)
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        DNI = reader["dni"].ToString(), // Nuevo campo mapeado
                        Email = reader["email"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        FechaRegistro = Convert.ToDateTime(reader["fechaRegistro"])
                    };

                    lista.Add(cliente);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mapear cliente: " + ex.Message);
            }
        }


        public Cliente Listar(SqlDataReader reader)
        {
            try
            {

                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        DNI = reader["dni"].ToString(), // Nuevo campo mapeado
                        Email = reader["email"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        FechaRegistro = Convert.ToDateTime(reader["fechaRegistro"])
                    };
                    return cliente;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }


        }


    }
}