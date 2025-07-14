using System.Security.Principal;

namespace Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }



        public string NombreCompleto
        {
            get { return this.Nombre + " " + this.Apellido; }
        }


        public string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public override string ToString()
        {
            return $"{Id} - {ObtenerNombreCompleto()}";
        }
    }

}