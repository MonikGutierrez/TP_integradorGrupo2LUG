using System;
using System.Collections.Generic;
using System.Transactions;
using DAL;
using Entity;
using static System.Formats.Asn1.AsnWriter;

namespace BLL
{
    public class CitaBusiness
    {
        private readonly CitaDAO dao = new CitaDAO();

        public List<Cita> ListarTodo()
        {
           
            try
            {

                return dao.ListarTodo();
       
            }
            catch (Exception)
            {
                throw;
            }

            
        }


        public void Agregar(Cita cita)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (cita.ClienteId < 0)
                    {
                        throw new Exception("Debe seleccionar un cliente válido");
                    }

                    if (cita.TipoEstado == null)
                    {
                        throw new Exception("Debe seleccionar un estado válido");
                    }


                    dao.Agregar(cita);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Modificar(Cita cita)
        {
            
            try
            {
                using (var scope = new TransactionScope())
                {
                    dao.Modificar(cita);
                    scope.Complete();
                }
                   
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Eliminar(Cita cita)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    if (cita.Id <= 0)
                        throw new Exception("ID inválido para eliminar.");

                    dao.Eliminar(cita);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}