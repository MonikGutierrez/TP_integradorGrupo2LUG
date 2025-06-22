using Entity;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class ClienteBusiness
    {
        private ClienteDAO dao = new ClienteDAO();

        public List<Cliente> Listar()
        {
            return dao.Listar();
        }

        public void Agregar(Cliente cliente)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El nombre y apellido son obligatorios.");

            dao.Agregar(cliente);
        }
        public void Modificar(Cliente cliente)
        {
            if (cliente == null || cliente.Id <= 0)
                throw new Exception("Cliente inválido.");

            dao.Modificar(cliente);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para eliminar.");

            dao.Eliminar(id);
        }

    }
}

