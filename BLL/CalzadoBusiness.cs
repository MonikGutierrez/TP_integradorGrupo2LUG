using System;
using System.Collections.Generic;
using System.Transactions;
using DAL;
using Entity;
using static System.Formats.Asn1.AsnWriter;

namespace BLL
{
    public class CalzadoBusiness
    {
        private readonly ProductoBusiness _productoBusiness = new ProductoBusiness();
        //private readonly VentaDAO _ventaDao = new VentaDAO(); // Para verificar ventas activas

        public void Agregar(Calzado calzado)
        {
            
                try
                {
                    using (var scope = new TransactionScope())
                    { 
                    if (calzado.Numero <= 0)
                        throw new Exception("El número debe ser mayor a 0.");

                    if (string.IsNullOrWhiteSpace(calzado.Categoria))
                        throw new Exception("La categoría es obligatoria.");

                    if (calzado.StockMinimo < 2)
                        throw new Exception("El stock mínimo debe ser al menos 2.");

                    if (calzado.Stock < calzado.StockMinimo)
                        throw new Exception("El stock inicial no puede ser menor al stock mínimo.");

                    _productoBusiness.Agregar(calzado);

                    scope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar calzado: " + ex.Message);
                }
        }

        public void Modificar(Calzado calzado)
        {
            
                try
                {
                    using (var scope = new TransactionScope())
                    { 
                        if (calzado.Id <= 0)
                            throw new Exception("ID inválido.");

                        //throw new Exception("No se puede modificar un calzado con ventas activas.");

                        if (calzado.Stock < calzado.StockMinimo)
                            throw new Exception("El stock no puede ser menor al stock mínimo.");

                        _productoBusiness.Modificar(calzado);
                        scope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar calzado: " + ex.Message);
                }
        }

        public void Eliminar(Calzado calzado)
        {

            try
            {

                using (var scope = new TransactionScope())
                {
                    if (calzado.Id <= 0)
                        throw new Exception("ID inválido.");


                    _productoBusiness.Eliminar(calzado);
                    scope.Complete();
                }

            }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar calzado: " + ex.Message);
                }
        }

    }
}