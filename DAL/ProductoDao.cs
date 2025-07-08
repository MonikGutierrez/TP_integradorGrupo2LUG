using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Entity;
using System.Configuration;

namespace DAL
{
    public class ProductoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public int Agregar(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return Agregar(producto, conn);
            }
        }

        public int Agregar(Producto producto, SqlConnection conn) {
            string query = @"INSERT INTO Producto (tipoProducto, nombre, descripcion, modelo, color, temporada, precio, stock, fechaCreacion, fechaUltimaModificacion)
                                OUTPUT INSERTED.id
                                VALUES (@tipoProducto, @nombre, @descripcion, @modelo, @color, @temporada, @precio, @stock, @fechaCreacion, @fechaUltimaModificacion)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tipoProducto", producto.TipoProducto);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@modelo", producto.Modelo ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@color", producto.Color ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@temporada", producto.Temporada ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@stock", producto.Stock);
            cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
            cmd.Parameters.AddWithValue("@fechaUltimaModificacion", DateTime.Now);

            return (int)cmd.ExecuteScalar();
        }

        public void Modificar(Producto producto, SqlConnection conn) {
            String query = "UPDATE Producto SET nombre=@nombre, descripcion=@descripcion, modelo=@modelo, color=@color, temporada=@temporada, precio=@precio, stock=@stock, fechaUltimaModificacion=@modificado WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@modelo", producto.Modelo);
            cmd.Parameters.AddWithValue("@color", producto.Color);
            cmd.Parameters.AddWithValue("@temporada", producto.Temporada);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@stock", producto.Stock);
            cmd.Parameters.AddWithValue("@modificado", DateTime.Now);
            cmd.Parameters.AddWithValue("@id", producto.Id);
            cmd.ExecuteNonQuery();
        }
    }
}
