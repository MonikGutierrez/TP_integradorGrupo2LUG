using Entity;
using System;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entity
{
    public class Vestido : Producto
    {

        public string Estado { get; set; }
        public string Talle { get; set; }
        public string Disenador { get; set; }
        public int TiempoAjusteHoras { get; set; }
        public bool EsUnico { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

        public Vestido()
        {
        }

        //sobrecarga de metodo
        public Vestido(int id, string nombre, string descripcion, string modelo, string color, string temporada, decimal precio, int stock, DateTime fechaCreacion, DateTime fechaUltimaModificacion, string estado, string talle, string disenador, int tiempoAjusteHoras, bool esUnico)
        {
            try
            {

                // Asignación a propiedades heredadas
                Id = id;
                Nombre = nombre;
                Descripcion = descripcion;
                Modelo = modelo;
                Color = color;
                Temporada = temporada;
                Precio = precio;
                Stock = stock;
                FechaCreacion = fechaCreacion;
                FechaUltimaModificacion = fechaUltimaModificacion;

                // Campos específicos de Vestido
                Estado = estado;
                Talle = talle;
                Disenador = disenador;
                TiempoAjusteHoras = tiempoAjusteHoras;
                EsUnico = esUnico;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el vestido: {ex.Message}");
            }
        }

        public string ProductoCompleto
        {
            get { return "{Nombre} - Talle: {talle} - Precio: {Precio}"; }
        }

    }
}