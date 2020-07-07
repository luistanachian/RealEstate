using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;

namespace RealEstate.MVC.Controllers.READ
{
    [Route("api/v1/read/currency")]
    [ApiController]
    public class ReadCurrencyController : ControllerBase
    {
        public readonly IMonedasBusiness _monedasBusiness;
        public ReadCurrencyController(IMonedasBusiness monedasBusiness)
        {
            _monedasBusiness = monedasBusiness;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var monedas = _monedasBusiness.GetAll();
            if (monedas != null && monedas.Count() > 0)
                return Ok(monedas);

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(string id)
        {
            var moneda = _monedasBusiness.GetById(id);
            if (moneda != null)
                return Ok(moneda);

            return NoContent();
        }
    }
}
