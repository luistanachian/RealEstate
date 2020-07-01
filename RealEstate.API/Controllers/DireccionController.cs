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
        private readonly IDireccionEstadosBusiness _direccionEstadosBusiness;
        public DireccionController(IDireccionPaisesBusiness direccionPaisesBusiness,
            IDireccionEstadosBusiness direccionEstadosBusiness)
        {
            _direccionPaisesBusiness = direccionPaisesBusiness;
            _direccionEstadosBusiness = direccionEstadosBusiness;
        }

        #region Paises

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


        #endregion

        #region Estados

        [Route("estado/idpais/{idPais}")]
        [HttpGet]
        public IActionResult EstadosGetByIdPais(string idPais)
        {
            var estados = _direccionEstadosBusiness.GetByIdPais(idPais);
            if (estados != null && estados.Count() > 0)
                return Ok(estados);

            return NoContent();
        }
        [Route("estado/{id}")]
        [HttpGet]
        public IActionResult EstadosGetById(string id)
        {
            var estado = _direccionEstadosBusiness.GetById(id);
            if (estado != null)
                return Ok(estado);

            return NoContent();
        }
        [Route("estado")]
        [HttpPut]
        public IActionResult EstadosInsert(DireccionEstados estado)
        {
            var guardado = _direccionEstadosBusiness.Insert(estado);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("estado")]
        [HttpPost]
        public IActionResult EstadosUpdate(DireccionEstados estado)
        {
            var guardado = _direccionEstadosBusiness.Update(estado);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("estado/{id}")]
        [HttpDelete]
        public IActionResult EstadosDelete(string id)
        {
            var guardado = _direccionEstadosBusiness.Delete(id);
            if (guardado)
                return Ok();

            return BadRequest();
        }


        #endregion

    }
}
