using Entity;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class VentaBusiness
    {
        private VentaDAO dao = new VentaDAO();

        public void Agregar(Venta venta)
        {
            if (venta.Detalles == null || venta.Detalles.Count == 0)
                throw new Exception("Debe agregar al menos un producto.");
            dao.Agregar(venta);
        }

        public List<Venta> Listar()
        {
            return dao.Listar();
        }
    }
}
