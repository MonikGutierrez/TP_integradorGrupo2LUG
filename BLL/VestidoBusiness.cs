using System;
using System.Collections.Generic;
using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class VestidoBusiness
    {
        private readonly ProductoBusiness _productoBusiness = new ProductoBusiness();


        public void Agregar(Vestido vestido)
        {

                try
                {
                    using (var scope = new TransactionScope())
                    {
                        if (string.IsNullOrWhiteSpace(vestido.Talle))
                            throw new Exception("El talle es obligatorio.");

                        if (string.IsNullOrWhiteSpace(vestido.Disenador))
                            throw new Exception("El diseñador es obligatorio.");

                        if (vestido.TiempoAjusteHoras <= 0)
                            throw new Exception("El tiempo de ajuste debe ser mayor a 0.");

                        if (vestido.Precio <= 0)
                            throw new Exception("El precio debe ser mayor a 0.");

                        _productoBusiness.Agregar(vestido);

                        scope.Complete();

                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar vestido: " + ex.Message);
                }
        }

        public void Modificar(Vestido vestido)
        {

                try
                {
                    using (var scope = new TransactionScope())
                    {
                        if (vestido.Id <= 0)
                            throw new Exception("ID inválido.");
                        if (string.IsNullOrWhiteSpace(vestido.Talle))
                            throw new Exception("El talle es obligatorio.");

                        if (string.IsNullOrWhiteSpace(vestido.Disenador))
                            throw new Exception("El diseñador es obligatorio.");

                        if (vestido.TiempoAjusteHoras <= 0)
                            throw new Exception("El tiempo de ajuste debe ser mayor a 0.");

                        if (vestido.Precio <= 0)
                            throw new Exception("El precio debe ser mayor a 0.");

                        _productoBusiness.Modificar(vestido);
                        scope.Complete();
                    }

                }   
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar vestido: " + ex.Message);
                }
        }

        public void Eliminar(Vestido vestido)
        {
                try
                {

                    using (var scope = new TransactionScope())
                    {

                        if (vestido.Id <= 0)
                            throw new Exception("ID inválido.");

                        _productoBusiness.Eliminar(vestido);
                        scope.Complete();
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar vestido: " + ex.Message);
                }
        }


    }
}