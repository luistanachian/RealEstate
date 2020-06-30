using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Business.Interface;
using RealEstate.Models.Entity;

namespace RealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedasController : ControllerBase
    {
        public readonly IMonedasBusiness _monedasBusiness;
        public MonedasController(IMonedasBusiness monedasBusiness)
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