using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace LAB4_practica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunctionController : ControllerBase
    {
        private readonly IFunctionServices _functionServices;

        public FunctionController(IFunctionServices functionServices)
        {
            _functionServices = functionServices;
        }

        [HttpGet]
        public ActionResult<List<Function>> GetAll()
        {
            return Ok(_functionServices.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var func = _functionServices.GetFunctionById(id);
            if (func == null)
            {
                return NotFound();
            }
            return Ok(func);
        }

        [HttpPost]
        public ActionResult AddFunction([FromBody] Function func) 
        {
            _functionServices.AddFunction(func);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateFunction([FromBody] Function func, int id)
        {
            _functionServices.UpdateFunction(func, id);
            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteFunction(int id)
        {
            var del = _functionServices.DeleteFunction(id);

            if (!del)
            {
                return NotFound();                
            }

            return NoContent();
        }



    }
}
