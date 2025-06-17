using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Transactions;
using Entity;
using MPP;

namespace DAL
{
    public class VestidoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public List<Vestido> Listar()
        {
            List<Vestido> lista = new List<Vestido>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Producto INNER JOIN Vestido ON Producto.id = Vestido.id WHERE tipoProducto = 'Vestido'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                VestidoMapper mapper = new VestidoMapper();
                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }

        public void Agregar(Vestido vestido)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(
                    "INSERT INTO Producto VALUES (@id, @tipoProducto, @nombre, @descripcion, @modelo, @color, @temporada, @precio, @stock, @fechaCreacion, @fechaModificacion)", conn);
                cmd1.Parameters.AddWithValue("@id", vestido.Id);
                cmd1.Parameters.AddWithValue("@tipoProducto", "Vestido");
                cmd1.Parameters.AddWithValue("@nombre", vestido.Nombre);
                cmd1.Parameters.AddWithValue("@descripcion", vestido.Descripcion);
                cmd1.Parameters.AddWithValue("@modelo", vestido.Modelo);
                cmd1.Parameters.AddWithValue("@color", vestido.Color);
                cmd1.Parameters.AddWithValue("@temporada", vestido.Temporada);
                cmd1.Parameters.AddWithValue("@precio", vestido.Precio);
                cmd1.Parameters.AddWithValue("@stock", vestido.Stock);
                cmd1.Parameters.AddWithValue("@fechaCreacion", vestido.FechaCreacion);
                cmd1.Parameters.AddWithValue("@fechaModificacion", vestido.FechaUltimaModificacion);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(
                    "INSERT INTO Vestido VALUES (@id, @talle, @disenador, @estado, @tiempoAjuste)", conn);
                cmd2.Parameters.AddWithValue("@id", vestido.Id);
                cmd2.Parameters.AddWithValue("@talle", vestido.Talle);
                cmd2.Parameters.AddWithValue("@disenador", vestido.Disenador);
                cmd2.Parameters.AddWithValue("@estado", vestido.Estado);
                cmd2.Parameters.AddWithValue("@tiempoAjuste", vestido.TiempoAjusteHoras);
                cmd2.ExecuteNonQuery();

                scope.Complete();
            }
        }

        public void Modificar(Vestido vestido)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(
                    "UPDATE Producto SET nombre=@nombre, descripcion=@descripcion, modelo=@modelo, color=@color, temporada=@temporada, precio=@precio, stock=@stock, fechaUltimaModificacion=@modificado WHERE id=@id", conn);
                cmd1.Parameters.AddWithValue("@nombre", vestido.Nombre);
                cmd1.Parameters.AddWithValue("@descripcion", vestido.Descripcion);
                cmd1.Parameters.AddWithValue("@modelo", vestido.Modelo);
                cmd1.Parameters.AddWithValue("@color", vestido.Color);
                cmd1.Parameters.AddWithValue("@temporada", vestido.Temporada);
                cmd1.Parameters.AddWithValue("@precio", vestido.Precio);
                cmd1.Parameters.AddWithValue("@stock", vestido.Stock);
                cmd1.Parameters.AddWithValue("@modificado", vestido.FechaUltimaModificacion);
                cmd1.Parameters.AddWithValue("@id", vestido.Id);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(
                    "UPDATE Vestido SET talle=@talle, disenador=@disenador, estado=@estado, tiempoAjusteHoras=@tiempo WHERE id=@id", conn);
                cmd2.Parameters.AddWithValue("@talle", vestido.Talle);
                cmd2.Parameters.AddWithValue("@disenador", vestido.Disenador);
                cmd2.Parameters.AddWithValue("@estado", vestido.Estado);
                cmd2.Parameters.AddWithValue("@tiempo", vestido.TiempoAjusteHoras);
                cmd2.Parameters.AddWithValue("@id", vestido.Id);
                cmd2.ExecuteNonQuery();

                scope.Complete();
            }
        }

        public void Eliminar(int id)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd2 = new SqlCommand("DELETE FROM Vestido WHERE id = @id", conn);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("DELETE FROM Producto WHERE id = @id", conn);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.ExecuteNonQuery();

                scope.Complete();
            }
        }
    }
}
