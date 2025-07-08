using System.Collections.Generic;
using DAL;
using Entity;

namespace BLL
{
    public class CitaBusiness
    {
        private CitaDAO dao = new CitaDAO();

        public void Agregar(Cita cita)
        {
            dao.Agregar(cita);
        }

        public List<Cita> Listar()
        {
            return dao.Listar();
        }
    }
}
