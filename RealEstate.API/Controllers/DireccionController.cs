using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;

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
    }
}
