using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;

namespace RealEstate.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDireccionEstadosBusiness _direccionEstadosBusiness;
        private readonly IDireccionLocalidadesBusiness _direccionLocalidadesBusiness;
        private readonly IDireccionBarriosBusiness _direccionBarriosBusiness;
        public HomeController(IDireccionEstadosBusiness direccionEstadosBusiness,
            IDireccionLocalidadesBusiness direccionLocalidadesBusiness,
            IDireccionBarriosBusiness direccionBarriosBusiness)
        {
            _direccionEstadosBusiness = direccionEstadosBusiness;
            _direccionLocalidadesBusiness = direccionLocalidadesBusiness;
            _direccionBarriosBusiness = direccionBarriosBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("location/search/{word}")]
        [HttpGet]
        public async Task<IActionResult> SearchLocation(string word)
        {
            var localidades = _direccionLocalidadesBusiness.SearchLocalidades(word);
            if (localidades != null && localidades.Count() > 0)
                return Ok(localidades);

            return NoContent();
        }

    }
}
