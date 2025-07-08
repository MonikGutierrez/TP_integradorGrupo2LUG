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
    public class CalzadoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SarkanyDB"].ConnectionString;

        public List<Calzado> Listar()
        {
            List<Calzado> lista = new List<Calzado>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Producto INNER JOIN Calzado ON Producto.id = Calzado.id WHERE tipoProducto = 'Calzado'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                CalzadoMapper mapper = new CalzadoMapper();
                while (reader.Read())
                {
                    lista.Add(mapper.Mapear(reader));
                }
            }
            return lista;
        }

        public void Agregar(Calzado calzado)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                ProductoDAO productoDao = new ProductoDAO();
                int idProducto = productoDao.Agregar(calzado, conn);

                SqlCommand cmd2 = new SqlCommand(
                    "INSERT INTO Calzado (id, numero, categoria, stockMinimo) VALUES (@id, @numero, @categoria, @stockMinimo)", conn);
                cmd2.Parameters.AddWithValue("@id", idProducto);
                cmd2.Parameters.AddWithValue("@numero", calzado.Numero);
                cmd2.Parameters.AddWithValue("@categoria", calzado.Categoria);
                cmd2.Parameters.AddWithValue("@stockMinimo", calzado.StockMinimo);
                cmd2.ExecuteNonQuery();

                scope.Complete();
            }
        }

        public void Modificar(Calzado calzado)
        {
            using (TransactionScope scope = new TransactionScope())
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(
                    "UPDATE Producto SET nombre=@nombre, descripcion=@descripcion, modelo=@modelo, color=@color, temporada=@temporada, precio=@precio, stock=@stock, fechaUltimaModificacion=@modificado WHERE id=@id", conn);
                cmd1.Parameters.AddWithValue("@nombre", calzado.Nombre);
                cmd1.Parameters.AddWithValue("@descripcion", calzado.Descripcion);
                cmd1.Parameters.AddWithValue("@modelo", calzado.Modelo);
                cmd1.Parameters.AddWithValue("@color", calzado.Color);
                cmd1.Parameters.AddWithValue("@temporada", calzado.Temporada);
                cmd1.Parameters.AddWithValue("@precio", calzado.Precio);
                cmd1.Parameters.AddWithValue("@stock", calzado.Stock);
                cmd1.Parameters.AddWithValue("@modificado", calzado.FechaUltimaModificacion);
                cmd1.Parameters.AddWithValue("@id", calzado.Id);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(
                    "UPDATE Calzado SET numero=@numero, categoria=@categoria, stockMinimo=@stockMinimo WHERE id=@id", conn);
                cmd2.Parameters.AddWithValue("@numero", calzado.Numero);
                cmd2.Parameters.AddWithValue("@categoria", calzado.Categoria);
                cmd2.Parameters.AddWithValue("@stockMinimo", calzado.StockMinimo);
                cmd2.Parameters.AddWithValue("@id", calzado.Id);
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

                SqlCommand cmd2 = new SqlCommand("DELETE FROM Calzado WHERE id = @id", conn);
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