using Entity;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class CalzadoBusiness
    {
        private CalzadoDAO dao = new CalzadoDAO();

        public List<Calzado> Listar()
        {
            return dao.Listar();
        }

        public void Agregar(Calzado calzado)
        {
            if (string.IsNullOrEmpty(calzado.Nombre))
                throw new Exception("El nombre es obligatorio.");
            dao.Agregar(calzado);
        }

        public void Modificar(Calzado calzado)
        {
            if (calzado.Id <= 0)
                throw new Exception("ID inválido.");
            dao.Modificar(calzado);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");
            dao.Eliminar(id);
        }
    }
}
