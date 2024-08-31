using Application.Dtos.Request;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace LAB4_practica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]
    public class FunctionController : ControllerBase
    {
        private readonly IFunctionServices _functionServices;

        public FunctionController(IFunctionServices functionServices)
        {
            _functionServices = functionServices;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var func = _functionServices.GetFunctionById(id);
            if (func == null)
            {
                return NotFound(new { message = "No se encontro la funcion" });
            }
            return Ok(func);
        }

        [HttpPost]
        public ActionResult AddFunction([FromBody] FunctionRequestDto data) 
        {
            _functionServices.AddFunction(data);
            return Ok(new { message = "Funcion agregada correctamente"});
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
                return NotFound(new { message = "No se encontro la funcion" });                
            }

            return NoContent();
        }



    }
}
