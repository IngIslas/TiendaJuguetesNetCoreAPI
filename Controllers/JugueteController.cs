using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TiendaJuguetesAPI.Conexions;
using TiendaJuguetesAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TiendaJuguetesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugueteController : Controller
    {

        private readonly TiendaContext _context;

        public JugueteController(TiendaContext context)
        {
            _context = context;
        }


        // GET: api/<JugueteController>
        [HttpGet]
        public IActionResult GetJuguetes()
        {
            try
            {
            return Ok(_context.Juguetes.ToList());

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // GET api/<JugueteController>/5
        [HttpGet("{id}")]
        public IActionResult GetJuguete(int id)
        {
            return Ok(_context.Juguetes.FirstOrDefault(x => x.Id == id));
        }

        // POST api/<JugueteController>
        [HttpPost]
        public IActionResult AgregarJuguete([FromBody] Juguete value)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(value);
                    var res = _context.SaveChanges();
                    return Ok("Guardado exitosamente");
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            return BadRequest("Los datos proporcionados no son correctos");
        }

        // PUT api/<JugueteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JugueteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
