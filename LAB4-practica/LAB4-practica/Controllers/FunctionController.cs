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
        public ActionResult AddFunction([FromBody] FunctionRequestDto func) 
        {
            var fun = _functionServices.AddFunction(func);

            if (fun == false) return BadRequest();

            return Ok(new { message = "Funcion agregada correctamente"});
        }

        [HttpPut("{id}")]
        public ActionResult UpdateFunction(FunctionRequestDto func, int id)
        {
            if(id != func.Id)
            {
                return BadRequest();
            }

            var fun = _functionServices.UpdateFunction(func, id);

            if (fun == false) return NotFound("Function not found");

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
