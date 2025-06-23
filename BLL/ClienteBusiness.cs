using DAL;
using Entity;
using System.Collections.Generic;
using System.Net.Mail;

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
            ValidarCliente(cliente);
            dao.Agregar(cliente);
        }
        public void Modificar(Cliente cliente)
        {
            if (cliente == null || cliente.Id <= 0)
                throw new Exception("Cliente inválido.");
            ValidarCliente(cliente);
            dao.Modificar(cliente);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para eliminar.");

            dao.Eliminar(id);
        }

        private void ValidarCliente(Cliente cliente) {
            // Validamos que el nombre y apellido no sea vacio
            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El nombre y apellido son obligatorios.");

            // Validamos que el telefono no sea vacio
            if (string.IsNullOrWhiteSpace(cliente.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            // Validamos que el email no sea vacio
            if (string.IsNullOrWhiteSpace(cliente.Email))
                throw new Exception("El email es obligatorio.");

            // Validamos que el telefono no contenga letras
            if (!cliente.Telefono.Trim().All(char.IsDigit))
                throw new Exception("El teléfono ingresado no debe contener letras.");
            
            // Validamos que el telefono contenga menos de 8 digitos
            if (cliente.Telefono.Trim().Length < 8)
                throw new Exception("El teléfono ingresado debe contener más de 8 dígitos.");

            // Validamos que el mail tenga un formato valido
            if (!EsEmailValido(cliente.Email.Trim()))
                throw new Exception("El formato del email ingresado no es válido.");
        }

        bool EsEmailValido(string email) {
            try {
                var direccion = new MailAddress(email);
                return direccion.Address == email;
            } catch {
                return false;
            }
        }

    }
}

