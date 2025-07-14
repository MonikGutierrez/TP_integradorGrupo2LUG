using System;
using Microsoft.Data.SqlClient;
using Entity;

namespace MPP
{
    public class ProductoMapper
    {

        public List<Producto> ListarTodo(SqlDataReader reader)
        {
            try
            {
                List<Producto> lista = new List<Producto>();

                while (reader.Read())
                {
                    if (reader["categoria"] != DBNull.Value) //calzado
                    {
                        Calzado oCalzado = new Calzado();
                        oCalzado.Id = Convert.ToInt32(reader["id"]);
                        oCalzado.Numero = reader["numero"] != DBNull.Value ? Convert.ToInt32(reader["numero"]) : 0;
                        oCalzado.Categoria = reader["categoria"] != DBNull.Value ? reader["categoria"].ToString() : string.Empty;
                        oCalzado.StockMinimo = reader["stockMinimo"] != DBNull.Value ? Convert.ToInt32(reader["stockMinimo"]) : 0;
                        oCalzado.Nombre = reader["nombre"].ToString();
                        oCalzado.Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : string.Empty;
                        oCalzado.Modelo = reader["modelo"] != DBNull.Value ? reader["modelo"].ToString() : string.Empty;
                        oCalzado.Color = reader["color"] != DBNull.Value ? reader["color"].ToString() : string.Empty;
                        oCalzado.Temporada = reader["temporada"] != DBNull.Value ? reader["temporada"].ToString() : string.Empty;
                        oCalzado.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0;
                        oCalzado.Stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0;
                        oCalzado.FechaCreacion = reader["fechaCreacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaCreacion"]) : DateTime.MinValue;
                        lista.Add(oCalzado);

                    }
                    else
                    {

                        Vestido oVestido = new Vestido();
                        oVestido.Id = Convert.ToInt32(reader["id"]);
                        oVestido.Nombre = reader["nombre"].ToString();
                        oVestido.Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : string.Empty;
                        oVestido.Modelo = reader["modelo"] != DBNull.Value ? reader["modelo"].ToString() : string.Empty;
                        oVestido.Color = reader["color"] != DBNull.Value ? reader["color"].ToString() : string.Empty;
                        oVestido.Temporada = reader["temporada"] != DBNull.Value ? reader["temporada"].ToString() : string.Empty;
                        oVestido.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0;
                        oVestido.Stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0;
                        oVestido.FechaCreacion = reader["fechaCreacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaCreacion"]) : DateTime.MinValue;
                        oVestido.FechaUltimaModificacion = reader["fechaUltimaModificacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaUltimaModificacion"]) : DateTime.MinValue;

                        oVestido.Talle = reader["talle"] != DBNull.Value ? reader["talle"].ToString() : string.Empty;
                        oVestido.Disenador = reader["disenador"] != DBNull.Value ? reader["disenador"].ToString() : string.Empty;
                        oVestido.Estado = reader["estado"] != DBNull.Value ? reader["estado"].ToString() : string.Empty;
                        oVestido.TiempoAjusteHoras = reader["tiempoAjusteHoras"] != DBNull.Value ? Convert.ToInt32(reader["tiempoAjusteHoras"]) : 0;
                        oVestido.EsUnico = reader["es_unico"] != DBNull.Value ? Convert.ToBoolean(reader["es_unico"]) : false;
                        lista.Add(oVestido);

                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Vestido> ListarTodoVestido(SqlDataReader reader)
        {
            try
            {
                List<Vestido> lista = new List<Vestido>();

                while (reader.Read())
                {

                    Vestido oVestido = new Vestido();
                    oVestido.Id = Convert.ToInt32(reader["id"]);
                    oVestido.Nombre = reader["nombre"].ToString();
                    oVestido.Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : string.Empty;
                    oVestido.Modelo = reader["modelo"] != DBNull.Value ? reader["modelo"].ToString() : string.Empty;
                    oVestido.Color = reader["color"] != DBNull.Value ? reader["color"].ToString() : string.Empty;
                    oVestido.Temporada = reader["temporada"] != DBNull.Value ? reader["temporada"].ToString() : string.Empty;
                    oVestido.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0;
                    oVestido.Stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0;
                    oVestido.FechaCreacion = reader["fechaCreacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaCreacion"]) : DateTime.MinValue;
                    oVestido.FechaUltimaModificacion = reader["fechaUltimaModificacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaUltimaModificacion"]) : DateTime.MinValue;

                    oVestido.Talle = reader["talle"] != DBNull.Value ? reader["talle"].ToString() : string.Empty;
                    oVestido.Disenador = reader["disenador"] != DBNull.Value ? reader["disenador"].ToString() : string.Empty;
                    oVestido.Estado = reader["estado"] != DBNull.Value ? reader["estado"].ToString() : string.Empty;
                    oVestido.TiempoAjusteHoras = reader["tiempoAjusteHoras"] != DBNull.Value ? Convert.ToInt32(reader["tiempoAjusteHoras"]) : 0;
                    oVestido.EsUnico = reader["es_unico"] != DBNull.Value ? Convert.ToBoolean(reader["es_unico"]) : false;
                    lista.Add(oVestido);

                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public List<Calzado> ListarTodoCalzado(SqlDataReader reader)
        {
            try
            {
                List<Calzado> lista = new List<Calzado>();

                while (reader.Read())
                {

                    Calzado oCalzado = new Calzado();
                    oCalzado.Id = Convert.ToInt32(reader["id"]);
                    oCalzado.Nombre = reader["nombre"].ToString();
                    oCalzado.Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : string.Empty;
                    oCalzado.Modelo = reader["modelo"] != DBNull.Value ? reader["modelo"].ToString() : string.Empty;
                    oCalzado.Color = reader["color"] != DBNull.Value ? reader["color"].ToString() : string.Empty;
                    oCalzado.Temporada = reader["temporada"] != DBNull.Value ? reader["temporada"].ToString() : string.Empty;
                    oCalzado.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0;
                    oCalzado.Stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0;
                    oCalzado.FechaCreacion = reader["fechaCreacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaCreacion"]) : DateTime.MinValue;

                    oCalzado.Numero = reader["numero"] != DBNull.Value ? Convert.ToInt32(reader["numero"]) : 0;
                    oCalzado.Categoria = reader["categoria"] != DBNull.Value ? reader["categoria"].ToString() : string.Empty;
                    oCalzado.StockMinimo = reader["stockMinimo"] != DBNull.Value ? Convert.ToInt32(reader["stockMinimo"]) : 0;
                    lista.Add(oCalzado);

                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public Producto Listar(SqlDataReader reader)
        {
            try
            {

                while (reader.Read())
                {
                    if (reader["categoria"] != DBNull.Value) //calzado
                    {
                        Calzado oCalzado = new Calzado();
                        oCalzado.Id = Convert.ToInt32(reader["id"]);
                        oCalzado.Nombre = reader["nombre"].ToString();
                        oCalzado.Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : string.Empty;
                        oCalzado.Modelo = reader["modelo"] != DBNull.Value ? reader["modelo"].ToString() : string.Empty;
                        oCalzado.Color = reader["color"] != DBNull.Value ? reader["color"].ToString() : string.Empty;
                        oCalzado.Temporada = reader["temporada"] != DBNull.Value ? reader["temporada"].ToString() : string.Empty;
                        oCalzado.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0;
                        oCalzado.Stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0;
                        oCalzado.FechaCreacion = reader["fechaCreacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaCreacion"]) : DateTime.MinValue;

                        oCalzado.Numero = reader["numero"] != DBNull.Value ? Convert.ToInt32(reader["numero"]) : 0;
                        oCalzado.Categoria = reader["categoria"] != DBNull.Value ? reader["categoria"].ToString() : string.Empty;
                        oCalzado.StockMinimo = reader["stockMinimo"] != DBNull.Value ? Convert.ToInt32(reader["stockMinimo"]) : 0;
                        return oCalzado;

                    }
                    else
                    {

                        Vestido oVestido = new Vestido();
                        oVestido.Id = Convert.ToInt32(reader["id"]);
                        oVestido.Nombre = reader["nombre"].ToString();
                        oVestido.Descripcion = reader["descripcion"] != DBNull.Value ? reader["descripcion"].ToString() : string.Empty;
                        oVestido.Modelo = reader["modelo"] != DBNull.Value ? reader["modelo"].ToString() : string.Empty;
                        oVestido.Color = reader["color"] != DBNull.Value ? reader["color"].ToString() : string.Empty;
                        oVestido.Temporada = reader["temporada"] != DBNull.Value ? reader["temporada"].ToString() : string.Empty;
                        oVestido.Precio = reader["precio"] != DBNull.Value ? Convert.ToDecimal(reader["precio"]) : 0;
                        oVestido.Stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0;
                        oVestido.FechaCreacion = reader["fechaCreacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaCreacion"]) : DateTime.MinValue;
                        oVestido.FechaUltimaModificacion = reader["fechaUltimaModificacion"] != DBNull.Value ? Convert.ToDateTime(reader["fechaUltimaModificacion"]) : DateTime.MinValue;

                        oVestido.Talle = reader["talle"] != DBNull.Value ? reader["talle"].ToString() : string.Empty;
                        oVestido.Disenador = reader["disenador"] != DBNull.Value ? reader["disenador"].ToString() : string.Empty;
                        oVestido.Estado = reader["estado"] != DBNull.Value ? reader["estado"].ToString() : string.Empty;
                        oVestido.TiempoAjusteHoras = reader["tiempoAjusteHoras"] != DBNull.Value ? Convert.ToInt32(reader["tiempoAjusteHoras"]) : 0;
                        oVestido.EsUnico = reader["es_unico"] != DBNull.Value ? Convert.ToBoolean(reader["es_unico"]) : false;
                        return oVestido;

                    }
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
