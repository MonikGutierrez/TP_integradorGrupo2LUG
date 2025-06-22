using System.Collections.Generic;
using DAL;
using Entity;

namespace BLL
{
    public class PagoBusiness
    {
        private PagoDAO dao = new PagoDAO();

        public void Agregar(Pago pago)
        {
            dao.Agregar(pago);
        }

        public List<Pago> Listar()
        {
            return dao.Listar();
        }
    }
}
