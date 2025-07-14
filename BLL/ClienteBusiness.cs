using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class ClienteBusiness
    {
        private readonly ClienteDAO _dao = new ClienteDAO();

        public List<Cliente> ListarTodo()
        {
            
                try
                {
                    return _dao.ListarTodo();
                }
                catch (Exception)
                {
                    throw;
                }

        }

        public Cliente Listar(Cliente cliente)
        {
            try
            {
                return _dao.Listar(cliente);
                   
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Agregar(Cliente cliente)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    ValidarCliente(cliente);

                    if (_dao.ExisteDNI(cliente.DNI))
                        throw new Exception("El DNI ya está registrado.");

                    cliente.FechaRegistro = DateTime.Now;

                    _dao.Agregar(cliente);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar cliente: " + ex.Message);
            }

        }

        public void Modificar(Cliente cliente)
        {

            try
            {
                using (var scope = new TransactionScope())
                {
                    if (cliente == null || cliente.Id <= 0)
                        throw new Exception("Cliente inválido.");

                    ValidarCliente(cliente);

                    if (_dao.ExisteDNIParaOtroCliente(cliente.DNI, cliente.Id))
                        throw new Exception("El DNI ya está registrado para otro cliente.");

                    _dao.Modificar(cliente);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar cliente: " + ex.Message);
            }
        }

        public void Eliminar(Cliente cliente)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (cliente.Id <= 0)
                        throw new Exception("ID inválido para eliminar.");


                    _dao.Eliminar(cliente);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }

        private void ValidarCliente(Cliente cliente)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
                    throw new Exception("El nombre y apellido son obligatorios.");

                if (string.IsNullOrWhiteSpace(cliente.DNI))
                    throw new Exception("El DNI es obligatorio y contener no mas de 8 dígitos.");

                if (string.IsNullOrWhiteSpace(cliente.Telefono))
                    throw new Exception("El teléfono es obligatorio.");

                if (!cliente.Telefono.Trim().All(char.IsDigit))
                    throw new Exception("El teléfono no debe contener letras.");

                if (cliente.Telefono.Trim().Length < 8)
                    throw new Exception("El teléfono debe contener al menos 8 dígitos.");

                if (string.IsNullOrWhiteSpace(cliente.Email))
                    throw new Exception("El email es obligatorio.");
 
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}