using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Entity;
using MPP;

namespace DAL
{
    public class ReservaDAO
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public List<Reserva> Listar()
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT r.*, 
                           c.nombre AS clienteNombre, 
                           c.apellido AS clienteApellido, 
                           c.email AS clienteEmail, 
                           c.telefono AS clienteTelefono, 
                           c.fechaRegistro AS clienteFechaRegistro
                    FROM Reserva r
                    INNER JOIN Cliente c ON r.clienteId = c.id", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                ReservaMapper mapper = new ReservaMapper();

                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }

            return lista;
        }

        public void Agregar(Reserva reserva)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Reserva (clienteId, vestidoId, fechaReserva, fechaExpiracion, montoReservado, estado)
                    VALUES (@clienteId, @vestidoId, @fechaReserva, @fechaExpiracion, @montoReservado, @estado)", conn);

                cmd.Parameters.AddWithValue("@clienteId", reserva.ClienteId);
                cmd.Parameters.AddWithValue("@vestidoId", reserva.VestidoId);
                cmd.Parameters.AddWithValue("@fechaReserva", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@fechaExpiracion", reserva.FechaExpiracion);
                cmd.Parameters.AddWithValue("@montoReservado", reserva.MontoReservado);
                cmd.Parameters.AddWithValue("@estado", reserva.Estado);

                cmd.ExecuteNonQuery();
            }
        }

        public void Modificar(Reserva reserva)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Reserva SET
                        clienteId = @clienteId,
                        vestidoId = @vestidoId,
                        fechaReserva = @fechaReserva,
                        fechaExpiracion = @fechaExpiracion,
                        montoReservado = @montoReservado,
                        estado = @estado
                    WHERE id = @id", conn);

                cmd.Parameters.AddWithValue("@id", reserva.Id);
                cmd.Parameters.AddWithValue("@clienteId", reserva.ClienteId);
                cmd.Parameters.AddWithValue("@vestidoId", reserva.VestidoId);
                cmd.Parameters.AddWithValue("@fechaReserva", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@fechaExpiracion", reserva.FechaExpiracion);
                cmd.Parameters.AddWithValue("@montoReservado", reserva.MontoReservado);
                cmd.Parameters.AddWithValue("@estado", reserva.Estado);

                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Reserva WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
