using System.ComponentModel.DataAnnotations;

namespace asp_servicios.Nucleo
{
    public class Clientes
    {
        [Key] public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Puntos { get; set; }
        public bool Activo { get; set; }
    }
}
