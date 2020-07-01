using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;
using RealEstate.Models.Entity;
using System.Linq;

namespace RealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {
        private readonly IDireccionPaisesBusiness _direccionPaisesBusiness;
        public DireccionController(IDireccionPaisesBusiness direccionPaisesBusiness)
        {
            _direccionPaisesBusiness = direccionPaisesBusiness;
        }

        [Route("pais")]
        [HttpGet]
        public IActionResult PaisGetAll()
        {
            var paises = _direccionPaisesBusiness.GetAll();
            if (paises != null && paises.Count() > 0)
                return Ok(paises);

            return NoContent();
        }
        [Route("pais/{id}")]
        [HttpGet]
        public IActionResult PaisGetById(string id)
        {
            var pais = _direccionPaisesBusiness.GetById(id);
            if (pais != null)
                return Ok(pais);

            return NoContent();
        }
        [Route("pais")]
        [HttpPut]
        public IActionResult Insert(DireccionPaises pais)
        {
            var guardado = _direccionPaisesBusiness.Insert(pais);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("pais")]
        [HttpPost]
        public IActionResult Update(DireccionPaises pais)
        {
            var guardado = _direccionPaisesBusiness.Update(pais);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("pais/{id}")]
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var guardado = _direccionPaisesBusiness.Delete(id);
            if (guardado)
                return Ok();

            return BadRequest();
        }
    }
}
