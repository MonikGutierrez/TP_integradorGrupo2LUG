namespace Entity
{
    public class Cliente {
        public int Id { get; set; } // auto numérico en DB
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        public DateTime FechaRegistro { get; set; }

        public String NombreCompleto {
            get {  return $"{Nombre} {Apellido}"; }
        }
    }
}

