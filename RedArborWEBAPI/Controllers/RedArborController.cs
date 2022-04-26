using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RedArborLogic.EmployeeLogic;
using RedArborWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedArborWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedArborController : ControllerBase
    {
        private IConfiguration configuration;
        public RedArborController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }


        // GET: api/<RedArborController>
        [HttpGet]
        public IActionResult Get()
        {
            var message = new Message<List<Employee>>();
            List<Employee> result = EmployeeLogic.GetAllEmployees(configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);

            if (result.Count == 0)
            {
                message.ReturnMessage = "No se ha encontrado registros";
                return BadRequest(message);
            }
            else
            {
                message.IsSuccess = true;
                message.ReturnMessage = "Lista de empleados cargados de forma correcta";
                message.Data = result;
                return Ok(message);
            }
        }

        // GET api/<RedArborController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var message = new Message<Employee>();
            Employee result = EmployeeLogic.GetSingleEmployee(configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value, id);

            if(result == null)
            {
                message.ReturnMessage = "No se ha encontrado registros";
                return BadRequest(message);
            }
            else
            {
                message.IsSuccess = true;
                message.ReturnMessage = "Empleado encontrado de forma correcta";
                message.Data = result;
                return Ok(message);
            }
        }

        // POST api/<RedArborController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            var message = new Message<Employee>();
            string result = EmployeeLogic.CreateEmployee(configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value, employee);
            if (!string.IsNullOrEmpty(result))
            {
                message.ReturnMessage = result;
                return BadRequest(message);
            }
            else
            {
                message.IsSuccess = true;
                message.ReturnMessage = "Empleado creado de forma correcta";
                return Ok(message);
            }                
        }

        // PUT api/<RedArborController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EmployeeUpdate employeeUpdate)
        {
            var message = new Message<EmployeeUpdate>();
            string result = EmployeeLogic.UpdateEmployee(configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value, id,employeeUpdate);
            if (!string.IsNullOrEmpty(result))
            {
                message.ReturnMessage = result;
                return BadRequest(message);
            }
            else
            {
                message.IsSuccess = true;
                message.ReturnMessage = "Empleado actualizado de forma correcta";
                return Ok(message);
            }
        }

        // DELETE api/<RedArborController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var message = new Message<EmployeeUpdate>();
            string result = EmployeeLogic.DeleteEmployee(configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value, id);
            if (!string.IsNullOrEmpty(result))
            {
                message.ReturnMessage = result;
                return BadRequest(message);
            }
            else
            {
                message.IsSuccess = true;
                message.ReturnMessage = "Empleado eliminado de forma correcta";
                return Ok(message);
            }
        }
    }
}
