using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;

namespace RealEstate.API.Controllers.READ
{
    [Route("api/v1/read/address")]
    [ApiController]
    public class ReadDireccionesController : ControllerBase
    {
        private readonly IDireccionPaisesBusiness _direccionPaisesBusiness;
        private readonly IDireccionEstadosBusiness _direccionEstadosBusiness;
        private readonly IDireccionLocalidadesBusiness _direccionLocalidadesBusiness;
        private readonly IDireccionBarriosBusiness _direccionBarriosBusiness;
        public ReadDireccionesController(IDireccionPaisesBusiness direccionPaisesBusiness,
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
        [HttpGet]
        public IActionResult PaisGetAll()
        {
            var paises = _direccionPaisesBusiness.GetAll();
            if (paises != null && paises.Count() > 0)
                return Ok(paises);

            return NoContent();
        }
        [Route("country/{id}")]
        [HttpGet]
        public IActionResult PaisGetById(string id)
        {
            var pais = _direccionPaisesBusiness.GetById(id);
            if (pais != null)
                return Ok(pais);

            return NoContent();
        }

        #endregion

        #region state

        [Route("state/idpais/{idcountry}")]
        [HttpGet]
        public IActionResult EstadosGetByIdPais(string idcountry)
        {
            var estados = _direccionEstadosBusiness.GetByIdPais(idcountry);
            if (estados != null && estados.Count() > 0)
                return Ok(estados);

            return NoContent();
        }
        [Route("state/{id}")]
        [HttpGet]
        public IActionResult EstadosGetById(string id)
        {
            var estado = _direccionEstadosBusiness.GetById(id);
            if (estado != null)
                return Ok(estado);

            return NoContent();
        }

        #endregion

        #region location

        [Route("location/idstate/{idstate}")]
        [HttpGet]
        public IActionResult LocalidadesGetByIdPais(string idstate)
        {
            var Localidades = _direccionLocalidadesBusiness.GetByIdEstado(idstate);
            if (Localidades != null && Localidades.Count() > 0)
                return Ok(Localidades);

            return NoContent();
        }
        [Route("location/{id}")]
        [HttpGet]
        public IActionResult LocalidadesGetById(string id)
        {
            var estado = _direccionLocalidadesBusiness.GetById(id);
            if (estado != null)
                return Ok(estado);

            return NoContent();
        }

        #endregion

        #region district

        [Route("district/idlocation/{idlocation}")]
        [HttpGet]
        public IActionResult BarriosGetByIdLocalidad(string idlocation)
        {
            var estados = _direccionBarriosBusiness.GetByIdLocalidad(idlocation);
            if (estados != null && estados.Count() > 0)
                return Ok(estados);

            return NoContent();
        }
        [Route("district/{id}")]
        [HttpGet]
        public IActionResult BarriosGetById(string id)
        {
            var estado = _direccionBarriosBusiness.GetById(id);
            if (estado != null)
                return Ok(estado);

            return NoContent();
        }


        #endregion

    }
}
