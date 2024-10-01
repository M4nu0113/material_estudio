using asp_servicios.Nucleo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp_servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Clientes> Get()
        {
            var conexion = new Conexion();
            conexion.StringConnection= "server=SALAK301-12;database=db_cafeteria;Integrated Security=True;TrustServerCertificate=true;";
            conexion.Database.Migrate();

            conexion.Guardar(new Clientes()
            {
                Cedula = "123456789",
                Nombre = "Pepito",
                Apellido = "Perez",
                Fecha = DateTime.Now,
                Puntos = 4.6m,
                Activo = true,
            });
            conexion.GuardarCambios();

            return conexion.Listar<Clientes>();
        }
    }
}
