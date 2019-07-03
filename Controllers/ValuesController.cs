using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioClases.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var m1 = new Student("Horacio", 10, 34);
            var m2 = new Student("Juan", 8.33, 54);
            var m3 = new Student("Ignacio", 8, 23);
            var m4 = new Student("Marcelo", 7.33, 21);
            var m5 = new Student("German", 7, 30);
            var m6 = new Student("Soledad", 9.33, 22);
            var m7 = new Student("Maria", 8, 18);
            var m8 = new Student("Carlos", 5.33, 19);
            var m9 = new Student("Franco", 6.66, 17);
            var m10 = new Student("Florencia", 7.33, 18);
            var estudiantes = new List<Student>();
            estudiantes.Add(m1);
            estudiantes.Add(m2);
            estudiantes.Add(m3);
            estudiantes.Add(m4);
            estudiantes.Add(m5);
            estudiantes.Add(m6);
            estudiantes.Add(m7);
            estudiantes.Add(m8);
            estudiantes.Add(m9);
            estudiantes.Add(m10);
            return estudiantes.OrderBy(p => p.Promedio).ToList();
        }

        // GET api/values/5
        [HttpGet("{nombre}")]
        public ActionResult<Student> Get(string nombre)
        {
            var m1 = new Student("Horacio", 10, 34);
            var m2 = new Student("Juan", 8.33, 54);
            var m3 = new Student("Ignacio", 8, 23);
            var m4 = new Student("Marcelo", 7.33, 21);
            var m5 = new Student("German", 7, 30);
            var m6 = new Student("Soledad", 9.33, 22);
            var m7 = new Student("Maria", 8, 18);
            var m8 = new Student("Carlos", 5.33, 19);
            var m9 = new Student("Franco", 6.66, 17);
            var m10 = new Student("Florencia", 7.33, 18);
            var estudiantes = new List<Student>();
            estudiantes.Add(m1);
            estudiantes.Add(m2);
            estudiantes.Add(m3);
            estudiantes.Add(m4);
            estudiantes.Add(m5);
            estudiantes.Add(m6);
            estudiantes.Add(m7);
            estudiantes.Add(m8);
            estudiantes.Add(m9);
            estudiantes.Add(m10);
            for (int i = 0; i < 5; i++)
            {
                if (estudiantes[i].Nombre == nombre)
                {
                    return estudiantes[i];
                }
            }
            return null;

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
