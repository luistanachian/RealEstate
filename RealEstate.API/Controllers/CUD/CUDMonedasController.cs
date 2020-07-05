using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;
using RealEstate.Models.Entity;

namespace RealEstate.API.Controllers.CUD
{
    [Route("api/v1/cud/currency")]
    [ApiController]
    public class CUDMonedasController : ControllerBase
    {
        public readonly IMonedasBusiness _monedasBusiness;
        public CUDMonedasController(IMonedasBusiness monedasBusiness)
        {
            _monedasBusiness = monedasBusiness;
        }

        [HttpPut]
        public IActionResult Insert(Monedas moneda)
        {
            var guardado = _monedasBusiness.Insert(moneda);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [HttpPost]
        public IActionResult Update(Monedas moneda)
        {
            var guardado = _monedasBusiness.Update(moneda);
            if (guardado)
                return Ok();

            return BadRequest();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(string id)
        {
            var guardado = _monedasBusiness.Delete(id);
            if (guardado)
                return Ok();

            return BadRequest();
        }
    }
}
