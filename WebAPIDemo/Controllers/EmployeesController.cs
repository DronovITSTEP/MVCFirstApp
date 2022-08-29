using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        Employee[] employees = new Employee[]
        {
            new Employee {Id = 1, Name= "Alex", 
                CreatedDate = DateTime.Parse(DateTime.Today.ToString()), Age= 31},
            new Employee {Id = 2, Name= "Ivan",
                CreatedDate = DateTime.Parse(DateTime.Today.ToString()), Age= 55},
            new Employee {Id = 3, Name= "Elena",
                CreatedDate = DateTime.Parse(DateTime.Today.ToString()), Age= 28},
        };

        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = employees.FirstOrDefault(empl => empl.Id == id);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
