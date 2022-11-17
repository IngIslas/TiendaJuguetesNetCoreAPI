using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TiendaJuguetesAPI.Conexions;
using TiendaJuguetesAPI.Interfaces;
using TiendaJuguetesAPI.Models;
using TiendaJuguetesAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TiendaJuguetesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JugueteController : Controller
    {

        private readonly TiendaContext _context;
        public readonly IJugueteRepository _jugueteRepository;

        //public JugueteController(TiendaContext context)
        //{
        //    _context = context;
        //}
        public JugueteController(IJugueteRepository jugueteRepository)
        {
            _jugueteRepository = jugueteRepository;
        }

        [HttpGet]
        public IActionResult GetJuguetes()
        {
            try
            {
                return Ok(_jugueteRepository.GetAll().ToList()); ;

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetJuguete(int id)
        {
            try
            {
                return Ok(_jugueteRepository.GetById(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AgregarJuguete([FromBody] Juguete juguete)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _jugueteRepository.Insertar(juguete);
                    return Ok("Guardado exitosamente");
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            return BadRequest("Los datos proporcionados no son correctos");
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarJuguete(int id, [FromBody] Juguete juguete)
        {
            try
            {
                _jugueteRepository.Actualizar(id, juguete);
                return Ok("Exito al actualizar");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<JugueteController>/5
        [HttpDelete("{id}")]
        public IActionResult EliminarJuguete(int id)
        {
            try
            {
                _jugueteRepository.Eliminar(id);
                return Ok("Exito al borrar");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
