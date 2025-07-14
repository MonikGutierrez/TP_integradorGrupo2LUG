using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Entity;
using MPP;

namespace DAL
{
    public class ProductoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["AtelierSarkany"].ConnectionString;

        public List<Producto> ListarTodo()
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Producto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ProductoMapper mapper = new ProductoMapper();
                            return mapper.ListarTodo(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;

        }

        public List<Vestido> ListarTodoVestido()
        {
            List<Vestido> lista = new List<Vestido>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Producto WHERE categoria IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ProductoMapper mapper = new ProductoMapper();
                            return mapper.ListarTodoVestido(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;

        }

        public List<Calzado> ListarTodoCalzado()
        {
            List<Calzado> lista = new List<Calzado>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Producto WHERE categoria IS NOT NULL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ProductoMapper mapper = new ProductoMapper();
                            return mapper.ListarTodoCalzado(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;

        }

        public Producto Listar(Producto producto)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Producto WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", producto.Id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ProductoMapper mapper = new ProductoMapper();
                            return mapper.Listar(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;

        }

        public void Agregar(Producto producto)
        {
            try
            {

                if (producto.GetType() == typeof(Vestido))
                {
                    //ES VESTIDO
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string queryProducto = @"
                            INSERT INTO Producto (nombre, descripcion, modelo, color, temporada, precio, stock, fechaCreacion, fechaUltimaModificacion, talle, disenador, estado, tiempoAjusteHoras, es_unico)
                            OUTPUT INSERTED.Id
                            VALUES (@nombre, @descripcion, @modelo, @color, @temporada, @precio, @stock, @fechaCreacion, @fechaUltimaModificacion, @talle, @disenador, @estado, @tiempoAjusteHoras, @es_unico)";

                        using (SqlCommand cmdProducto = new SqlCommand(queryProducto, conn))
                        {
                            cmdProducto.Parameters.AddWithValue("@nombre", (object)producto.Nombre ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@descripcion", (object)producto.Descripcion ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@modelo", (object)producto.Modelo ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@color", (object)producto.Color ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@temporada", (object)producto.Temporada ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@precio", producto.Precio);
                            cmdProducto.Parameters.AddWithValue("@stock", producto.Stock);
                            cmdProducto.Parameters.AddWithValue("@fechaCreacion", producto.FechaCreacion);
                            cmdProducto.Parameters.AddWithValue("@fechaUltimaModificacion", (object)((Vestido)producto).FechaUltimaModificacion ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@talle", (object)((Vestido)producto).Talle ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@disenador", (object)((Vestido)producto).Disenador ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@estado", (object)((Vestido)producto).Estado ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@tiempoAjusteHoras", ((Vestido)producto).TiempoAjusteHoras);
                            cmdProducto.Parameters.AddWithValue("@es_unico", ((Vestido)producto).EsUnico);
                            producto.Id = (int)cmdProducto.ExecuteScalar();

                        }
                    }
                }
                else
                {
                    //ES CALZADO
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string queryProducto = @"
                            INSERT INTO Producto (nombre, descripcion, modelo, color, temporada, precio, stock, fechaCreacion, categoria, stockMinimo, numero)
                            OUTPUT INSERTED.Id
                            VALUES (@nombre, @descripcion, @modelo, @color, @temporada, @precio, @stock, @fechaCreacion, @categoria, @stockMinimo, @numero)";
                        using (SqlCommand cmdProducto = new SqlCommand(queryProducto, conn))
                        {

                            cmdProducto.Parameters.AddWithValue("@nombre", (object)producto.Nombre ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@descripcion", (object)producto.Descripcion ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@modelo", (object)producto.Modelo ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@color", (object)producto.Color ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@temporada", (object)producto.Temporada ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@precio", producto.Precio);
                            cmdProducto.Parameters.AddWithValue("@stock", producto.Stock);
                            cmdProducto.Parameters.AddWithValue("@fechaCreacion", producto.FechaCreacion);
                            cmdProducto.Parameters.AddWithValue("@categoria", (object)((Calzado)producto).Categoria);
                            cmdProducto.Parameters.AddWithValue("@stockMinimo", (object)((Calzado)producto).StockMinimo);
                            cmdProducto.Parameters.AddWithValue("@numero", (object)((Calzado)producto).Numero);
                            producto.Id = (int)cmdProducto.ExecuteScalar();

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Modificar(Producto producto)
        {
            try
            {
                if (producto.GetType() == typeof(Vestido))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string queryProducto = @"UPDATE Producto SET nombre=@nombre, descripcion=@descripcion, modelo=@modelo, color=@color, temporada=@temporada, precio=@precio, stock=@stock, fechaUltimaModificacion=@fechaUltimaModificacion, talle=@talle, disenador=@disenador, estado=@estado, tiempoAjusteHoras=@tiempoAjusteHoras, es_unico=@es_unico WHERE Id = @Id
                            ";
                        using (SqlCommand cmdProducto = new SqlCommand(queryProducto, conn))
                        {
                            cmdProducto.Parameters.AddWithValue("@nombre", (object)producto.Nombre ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@descripcion", (object)producto.Descripcion ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@modelo", (object)producto.Modelo ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@color", (object)producto.Color ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@temporada", (object)producto.Temporada ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@precio", producto.Precio);
                            cmdProducto.Parameters.AddWithValue("@stock", producto.Stock);
                            cmdProducto.Parameters.AddWithValue("@fechaUltimaModificacion", (object)((Vestido)producto).FechaUltimaModificacion ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@talle", (object)((Vestido)producto).Talle ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@disenador", (object)((Vestido)producto).Disenador ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@estado", (object)((Vestido)producto).Estado ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@tiempoAjusteHoras", ((Vestido)producto).TiempoAjusteHoras);
                            cmdProducto.Parameters.AddWithValue("@es_unico", ((Vestido)producto).EsUnico);
                            cmdProducto.Parameters.AddWithValue("@id", ((Vestido)producto).Id);
                            cmdProducto.ExecuteScalar();
                        }

                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string queryProducto = @"UPDATE Producto SET nombre=@nombre, descripcion=@descripcion, modelo=@modelo, color=@color, temporada=@temporada, precio=@precio, stock=@stock, categoria=@categoria, stockMinimo=@stockMinimo, numero=@numero WHERE Id = @Id";
                        using (SqlCommand cmdProducto = new SqlCommand(queryProducto, conn))
                        {
                            cmdProducto.Parameters.AddWithValue("@nombre", (object)producto.Nombre ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@descripcion", (object)producto.Descripcion ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@modelo", (object)producto.Modelo ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@color", (object)producto.Color ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@temporada", (object)producto.Temporada ?? DBNull.Value);
                            cmdProducto.Parameters.AddWithValue("@precio", producto.Precio);
                            cmdProducto.Parameters.AddWithValue("@stock", producto.Stock);
                            cmdProducto.Parameters.AddWithValue("@categoria", (object)((Calzado)producto).Categoria);
                            cmdProducto.Parameters.AddWithValue("@stockMinimo", (object)((Calzado)producto).StockMinimo);
                            cmdProducto.Parameters.AddWithValue("@numero", (object)((Calzado)producto).Numero);
                            cmdProducto.Parameters.AddWithValue("@id", (object)((Calzado)producto).Id);
                            cmdProducto.ExecuteScalar();

                        }

                    }

                }

            }
            catch (Exception)
            {
                throw;
            }
        }


        public void Eliminar(Producto producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var scope = new System.Transactions.TransactionScope())
                    {
                        string query = "DELETE FROM Producto WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", producto.Id);
                            cmd.ExecuteNonQuery();
                        }

                        scope.Complete();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
