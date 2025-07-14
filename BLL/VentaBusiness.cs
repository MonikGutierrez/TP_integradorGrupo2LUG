using System;
using System.Collections.Generic;
using System.Transactions;
using DAL;
using Entity;
using static System.Formats.Asn1.AsnWriter;

namespace BLL
{
    public class VentaBusiness
    {
        private readonly VentaDAO _dao = new VentaDAO();

        public List<Venta> ListarTodo()
        {
            try
            {
                List<Venta> lista = _dao.ListarTodo();

                // bucle para cargar objetos cliente y detalleVenta
                foreach (var venta in lista)
                {

                    if (venta.ClienteId != 0)
                    {
                        venta.Cliente = new ClienteBusiness().Listar(new Cliente { Id = venta.ClienteId });

                    }
                    venta.Detalles = new DetalleVentaBusiness().ObtenerDetallesPorVenta(venta.Id);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar ventas: " + ex.Message);
            }
        }

        public void Agregar(Venta venta)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (venta.Detalles == null)
                        venta.Detalles = new List<DetalleVenta>();

                    if (venta.Detalles.Count == 0)
                        throw new Exception("Error al agregar producto al carrito, no tiene productos.");

                    //venta
                    _dao.Agregar(venta);

                    //detalle de ventas
                    foreach (var detalle in venta.Detalles)
                    {
                        detalle.VentaId = venta.Id;
                        new DetalleVentaBusiness().Agregar(detalle);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar producto al carrito: " + ex.Message);
            }
        }

        public void Eliminar(Venta venta)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (venta.Id <= 0)
                        throw new Exception("Error al eliminar producto al carrito: ");

                    _dao.Eliminar(venta); // elimina la venta
                    scope.Complete();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar venta: " + ex.Message);
            }
        }



        public Venta ObtenerPorId(int id)
        {

                try
                {
                    using (var scope = new TransactionScope())
                    {
                        return _dao.ObtenerVentaPorId(id);
                        scope.Complete();
                    }
            
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener venta: " + ex.Message);
                }
        }

    }
}
