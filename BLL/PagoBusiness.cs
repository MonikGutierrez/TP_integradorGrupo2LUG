using System;
using System.Collections.Generic;
using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class PagoBusiness
    {
        private readonly PagoDAO _dao = new PagoDAO();

        public List<Pago> ListarTodo()
        {

            try
            {
                return _dao.ListarTodo();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar pagos: " + ex.Message);
            }
            return null;
        }



        public void Agregar(Pago pago)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (pago.Monto <= 0)
                        throw new Exception("El monto del pago debe ser mayor a 0.");

                    if (pago.MedioPago == "")
                        throw new Exception("El medio de pago es obligatorio.");

                    _dao.Agregar(pago);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar pago: " + ex.Message);
            }
        }

        public void Eliminar(Pago pago)
        {
            try
            {
                using (var scope = new System.Transactions.TransactionScope())
                {
                    _dao.Eliminar(pago);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar pago: " + ex.Message);
            }
        }


    }
}
