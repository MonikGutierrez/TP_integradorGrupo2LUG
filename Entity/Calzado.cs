using System;

namespace Entity
{
    public class Calzado : Producto
    {
        public decimal Numero { get; set; }
        public string Categoria { get; set; }
        public int StockMinimo { get; set; }


        public Calzado()
        {
        }

        public Calzado(int id, string nombre, string descripcion, string modelo, string color, string temporada, decimal precio, int stock, DateTime fechaCreacion, decimal numero, string categoria, int stockMinimo)
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



                // Asignación a propiedades propias
                Numero = numero;
                Categoria = categoria;
                StockMinimo = stockMinimo;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el vestido: {ex.Message}");
            }
        }

        public string ProductoCompleto
        {
            get { return "{Nombre} - Numero: {Numero} - Precio: {Precio}"; }
        }

    }
}
