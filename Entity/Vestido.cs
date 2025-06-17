using System;

namespace Entity
{
    public class Vestido : Producto
    {
        public string Talle { get; set; }
        public string Disenador { get; set; }
        public string Estado { get; set; }
        public int TiempoAjusteHoras { get; set; }

        public void CambiarEstado(string nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public bool EstaDisponible()
        {
            return Estado == "Disponible";
        }
    }
}
