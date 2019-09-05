using PeopleManagerWebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeopleManagerWebapi.Controllers
{
    public class EmployeesController : ApiController
    {
        List<Employee> empy = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name= "Marcos Navarro",
                Idade= 23,
                Cpf = "125558552",
                DateInsert = DateTime.Now,
                Address= new List<string>
                {
                    "Barro Preto",
                    "Barbacena"
                }
            },
            new Employee
            {
                Id = 2,
                Name= "Leonardo Viana ",
                Idade= 26,
                Cpf = "2554485225",
                DateInsert = DateTime.Now,
                Address= new List<string>
                {
                    "Caiçaras",
                    "Almenara"
                }
            },
            new Employee
            {
                Id = 3,
                Name= "Kevin Chagas",
                Idade= 22,
                Cpf = "125865552",
                DateInsert = DateTime.Now,
                Address= new List<string>
                {
                    "São Salvador",
                    "Belo Horizonte"
                }
            },
        };
        // GET api/<controller>
        [HttpGet]
        [Route("funcionarios/list")]
        public IEnumerable<Employee> Get()
        {
            return empy;
        }

        // GET api/<controller>/5

        [HttpGet]
        [Route("funcionarios/show/{id}")]
        public IHttpActionResult Get(int id)
        {
            var employee = empy.FirstOrDefault((e) => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("funcionarios/create")]
        public IHttpActionResult Post([FromBody]Employee value)
        {
            if (value == null)
            {
                return NotFound();
            }
            empy.Add(value);

            return Ok(value);
        }

        [HttpPost]
        [Route("funcionarios/update/{id}")]
        public IHttpActionResult Put(int id, [FromBody]Employee value)
        {

            if (empy.FirstOrDefault((e) => e.Id == id) == null)
            {
                return NotFound();
            }
          var employee =  empy.Where((e) => e.Id == id).Select(e =>
            {
                e.Id = value.Id;
                e.Name = value.Name;
                e.Cpf = value.Cpf;
                e.Idade = value.Idade;
                e.DateUpdate = DateTime.Now;
                e.Address = value.Address;
                return e;
            }).ToList();

            return Ok(employee);
        }

        // DELETE api/<controller>/5

        [HttpDelete]
        [Route("funcionarios/destroy/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var employee = empy.FirstOrDefault((e) => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            empy.Remove(employee);
            return Ok(employee);
        }
    }
}