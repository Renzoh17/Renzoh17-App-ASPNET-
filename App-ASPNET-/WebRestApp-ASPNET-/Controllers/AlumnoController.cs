using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebRestApp_ASPNET_.Models;
using WebRestApp_ASPNET_.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebRestApp_ASPNET_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        AlumnoService service;
        public AlumnoController(AlumnoService service)
        {
            this.service = service;
        }
        // GET: api/<AlumnoController>
        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return service.GetAll();
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult action = NotFound();
            Alumno? a = service.GetById(id);
            if(a != null) action = Ok(a);
            else action = BadRequest("No se encontro el Alumno");
            return action;
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public IActionResult Post([FromBody] Alumno value)
        {
            return Ok(service.Insert(value));
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Alumno value)
        {
            IActionResult action = NotFound();
            value.Id = id;
            bool r = service.Update(value);
            if (r) action = Ok("Se actualizo con exito el Alumno");
            else action = BadRequest("No se pudo actualizar el Alumno");
            return action;
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult action = NotFound();
            bool r = service.Delete(id);
            if (r) action = Ok("Se elimino con exito el Alumno");
            else action = BadRequest("No se pudo eliminar el Alumno");
            return action;
        }
    }
}
