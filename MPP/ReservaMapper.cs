using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class ReservaMapper
    {
        public Reserva Mapear(SqlDataReader reader)
        {
            // Creamos el objeto Reserva y le asignamos sus propiedades básicas
            Reserva reserva = new Reserva
            {
                Id = (int)reader["id"],
                ClienteId = (int)reader["clienteId"],
                VestidoId = (int)reader["vestidoId"],
                FechaReserva = Convert.ToDateTime(reader["fechaReserva"]),
                FechaExpiracion = Convert.ToDateTime(reader["fechaExpiracion"]),
                MontoReservado = (decimal)reader["montoReservado"],
                Estado = reader["estado"].ToString()
            };

            // Incluimos el objeto Cliente si las columnas están presentes en el SqlDataReader
            /* reserva.Cliente = new Cliente
             {
                 Id = (int)reader["clienteId"],
                 Nombre = reader["nombre"].ToString(),
                 Apellido = reader["apellido"].ToString(),
                 Email = reader["email"].ToString(),
                 Telefono = reader["telefono"].ToString(),
                 FechaRegistro = Convert.ToDateTime(reader["fechaRegistro"])
             };*/

            reserva.Cliente = new Cliente
            {

                Nombre = reader["clienteNombre"].ToString(),
                Apellido = reader["clienteApellido"].ToString(),
                Email = reader["clienteEmail"].ToString(),
                Telefono = reader["clienteTelefono"].ToString(),
                FechaRegistro = Convert.ToDateTime(reader["clienteFechaRegistro"])
            };

            return reserva;
        }
    }
}
