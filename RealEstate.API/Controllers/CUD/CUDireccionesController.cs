using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;
using RealEstate.Models.Entity;

namespace RealEstate.API.Controllers.CUD
{
    [Route("api/v1/cud/address")]
    [ApiController]
    public class CUDireccionesController : ControllerBase
    {
        private readonly IDireccionPaisesBusiness _direccionPaisesBusiness;
        private readonly IDireccionEstadosBusiness _direccionEstadosBusiness;
        private readonly IDireccionLocalidadesBusiness _direccionLocalidadesBusiness;
        private readonly IDireccionBarriosBusiness _direccionBarriosBusiness;
        public CUDireccionesController(IDireccionPaisesBusiness direccionPaisesBusiness,
            IDireccionEstadosBusiness direccionEstadosBusiness,
            IDireccionLocalidadesBusiness direccionLocalidadesBusiness,
            IDireccionBarriosBusiness direccionBarriosBusiness)
        {
            _direccionPaisesBusiness = direccionPaisesBusiness;
            _direccionEstadosBusiness = direccionEstadosBusiness;
            _direccionLocalidadesBusiness = direccionLocalidadesBusiness;
            _direccionBarriosBusiness = direccionBarriosBusiness;
        }

        #region country

        [Route("country")]
        [HttpPut]
        public IActionResult Insert(DireccionPaises country)
        {
            var guardado = _direccionPaisesBusiness.Insert(country);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("country")]
        [HttpPost]
        public IActionResult Update(DireccionPaises country)
        {
            var guardado = _direccionPaisesBusiness.Update(country);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("country/{id}")]
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var guardado = _direccionPaisesBusiness.Delete(id);
            if (guardado)
                return Ok();

            return BadRequest();
        }


        #endregion

        #region state

        [Route("state")]
        [HttpPut]
        public IActionResult EstadosInsert(DireccionEstados state)
        {
            var guardado = _direccionEstadosBusiness.Insert(state);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("state")]
        [HttpPost]
        public IActionResult EstadosUpdate(DireccionEstados state)
        {
            var guardado = _direccionEstadosBusiness.Update(state);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("state/{id}")]
        [HttpDelete]
        public IActionResult EstadosDelete(string id)
        {
            var guardado = _direccionEstadosBusiness.Delete(id);
            if (guardado)
                return Ok();

            return BadRequest();
        }


        #endregion

        #region location

        [Route("location")]
        [HttpPut]
        public IActionResult LocalidadesInsert(DireccionLocalidades location)
        {
            var guardado = _direccionLocalidadesBusiness.Insert(location);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("location")]
        [HttpPost]
        public IActionResult LocalidadesUpdate(DireccionLocalidades location)
        {
            var guardado = _direccionLocalidadesBusiness.Update(location);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("location/{id}")]
        [HttpDelete]
        public IActionResult LocalidadesDelete(string id)
        {
            var guardado = _direccionLocalidadesBusiness.Delete(id);
            if (guardado)
                return Ok();

            return BadRequest();
        }


        #endregion

        #region district

        [Route("district")]
        [HttpPut]
        public IActionResult BarriosInsert(DireccionBarrios district)
        {
            var guardado = _direccionBarriosBusiness.Insert(district);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("district")]
        [HttpPost]
        public IActionResult BarriosUpdate(DireccionBarrios district)
        {
            var guardado = _direccionBarriosBusiness.Update(district);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [Route("district/{id}")]
        [HttpDelete]
        public IActionResult BarriosDelete(string id)
        {
            var guardado = _direccionBarriosBusiness.Delete(id);
            if (guardado)
                return Ok();

            return BadRequest();
        }


        #endregion

    }
}
