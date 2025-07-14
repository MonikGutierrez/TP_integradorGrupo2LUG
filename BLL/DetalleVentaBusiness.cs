using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class DetalleVentaBusiness
    {
        private DetalleVentaDao _detalleDao;

        public DetalleVentaBusiness()
        {
            _detalleDao = new DetalleVentaDao();
        }

        public List<DetalleVenta> ObtenerDetallesPorVenta(int ventaId)
        {
            try
            {
                if (ventaId <= 0)
                    throw new ArgumentException("ID de venta inválido.");

                return _detalleDao.ListarPorVenta(ventaId);


            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los detalles de la venta: " + ex.Message);
            }
        }

        public void Agregar(DetalleVenta detalle)
        {
            
                try
                {
                    using (var scope = new TransactionScope())
                    {
                        if (detalle == null)
                            throw new ArgumentNullException(nameof(detalle), "El detalle no puede ser nulo.");
                        if (detalle.VentaId <= 0)
                            throw new ArgumentException("ID de venta inválido.");

                        if (detalle.Cantidad <= 0)
                            throw new ArgumentException("La cantidad debe ser mayor a 0.");

                        _detalleDao.Agregar(detalle);

                        scope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el detalle de venta: " + ex.Message);
                }
        }


        public void EliminarDetalle(int id)
        {
            
                try
                {
                    using (var scope = new TransactionScope())
                    {
                        if (id <= 0)
                            throw new ArgumentException("ID de detalle inválido.");

                        _detalleDao.Eliminar(id);
                        scope.Complete();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el detalle de venta: " + ex.Message);
                }
        }
    }
}
