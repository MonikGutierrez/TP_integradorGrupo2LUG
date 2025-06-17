using Entity;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class VestidoBusiness
    {
        private VestidoDAO dao = new VestidoDAO();

        public List<Vestido> Listar()
        {
            return dao.Listar();
        }

        public void Agregar(Vestido vestido)
        {
            if (string.IsNullOrEmpty(vestido.Nombre))
                throw new Exception("El nombre es obligatorio.");
            dao.Agregar(vestido);
        }

        public void Modificar(Vestido vestido)
        {
            if (vestido.Id <= 0)
                throw new Exception("ID inválido.");
            dao.Modificar(vestido);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");
            dao.Eliminar(id);
        }
    }
}
