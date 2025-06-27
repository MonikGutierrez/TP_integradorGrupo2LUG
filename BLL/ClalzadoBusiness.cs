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
            ValidarCalzado(calzado);
            dao.Agregar(calzado);
        }

        public void Modificar(Calzado calzado)
        {
            if (calzado.Id <= 0)
                throw new Exception("ID inválido.");
            ValidarCalzado(calzado);
            dao.Modificar(calzado);
        }

        private void ValidarCalzado(Calzado calzado) {
            // Validamos que el nombre no sea vacio
            if (string.IsNullOrWhiteSpace(calzado.Nombre))
                throw new Exception("El nombre es obligatorio.");

            // Validamos que el modelo no sea vacio
            if (string.IsNullOrWhiteSpace(calzado.Modelo))
                throw new Exception("El modelo es obligatorio.");

            // Validamos que la categoria no sea vacia
            if (string.IsNullOrWhiteSpace(calzado.Categoria))
                throw new Exception("La categoria es obligatoria.");

            // Validamos que la temporada no sea vacia
            if (string.IsNullOrWhiteSpace(calzado.Temporada))
                throw new Exception("La temporada es obligatoria.");

            // Validamos que el color no sea vacio
            if (string.IsNullOrWhiteSpace(calzado.Color))
                throw new Exception("El color es obligatoria.");

            // Validamos que el número sea válido
            if (calzado.Numero < 0 && calzado.Numero > 99)
                throw new Exception("El número ingresado no es válido.");

            // Validamos que el stock sea válido
            if (calzado.Stock < 0)
                throw new Exception("El stock ingresado no es válido.");

            // Validamos que el stockMinimo sea válido
            if (calzado.StockMinimo < 0)
                throw new Exception("El stock mínimo ingresado no es válido.");

            // Validamos que el precio sea válido
            if (calzado.Precio < 0)
                throw new Exception("El precio ingresado no es válido.");
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");
            dao.Eliminar(id);
        }
    }
}
