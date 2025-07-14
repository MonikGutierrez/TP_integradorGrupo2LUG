using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class ProductoBusiness
    {
        private readonly ProductoDAO _dao = new ProductoDAO();

        public List<Producto> ListarTodo()
        {
            
                try
                {
                    return _dao.ListarTodo();
                    
                }
                catch (Exception)
                {
                    throw;
                }

        }

        public List<Vestido> ListarTodoVestido()
        {

                try
                {
                    return _dao.ListarTodoVestido();
                    
                }
                catch (Exception)
                {
                    throw;
                }

        }

        public List<Calzado> ListarTodoCalzado()
        {
         
                try
                {
                    return _dao.ListarTodoCalzado();
                    
                }
                catch (Exception)
                {
                    throw;
                }
            

        }

        public Producto Listar(Producto producto)
        {
            try
            {
                return _dao.Listar(producto);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Agregar(Producto producto)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (string.IsNullOrWhiteSpace(producto.Nombre))
                        throw new Exception("El nombre del producto es obligatorio.");

                    if (producto.Precio <= 0)
                        throw new Exception("El precio debe ser mayor a 0.");

                    producto.FechaCreacion = DateTime.Now;
                    _dao.Agregar(producto);
                    scope.Complete();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar producto: " + ex.Message);
            }
        }

        public void Modificar(Producto producto)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (producto.Id <= 0)
                        throw new Exception("ID inválido.");

                    if (string.IsNullOrWhiteSpace(producto.Nombre))
                        throw new Exception("El nombre del producto es obligatorio.");

                    if (producto.Precio <= 0)
                        throw new Exception("El precio debe ser mayor a 0.");


                    _dao.Modificar(producto);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar producto: " + ex.Message);
            }
        }

        public void Eliminar(Producto producto)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (producto.Id <= 0)
                        throw new Exception("ID inválido.");

                    _dao.Eliminar(producto);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar producto: " + ex.Message);
            }
        }


    }
}
