using System;
using System.Collections.Generic;
using DAL;
using Entity;

using System.Linq;
namespace BLL
{
    public class ReservaBusiness
    {
        private ReservaDAO dao = new ReservaDAO();

        public void Agregar(Reserva reserva)
        {
            if (reserva.FechaExpiracion <= reserva.FechaReserva)
                throw new Exception("La fecha de expiración debe ser posterior a la de reserva.");
            dao.Agregar(reserva);
        }
      
        public List<Reserva> ListarPorCliente(int clienteId)
        {
            return dao.Listar().Where(r => r.ClienteId == clienteId).ToList();
        }

        public List<Reserva> Listar()
        {
            return dao.Listar();
        }
    }
}
