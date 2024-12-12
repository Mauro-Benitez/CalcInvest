using CalcInvest.Application;
using CalcInvest.Core;
using CalcInvest.Core.Enum;
using Microsoft.AspNetCore.Mvc;

namespace CalcInvest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosSimplesController : Controller
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Calc([FromBody] JurosSimplesDTO jurosSimples)
        {
            if (jurosSimples == null) return BadRequest();

            var taxaDeJuros = new TaxaDeJuros(
                jurosSimples.TaxaDeJuros,
                jurosSimples.AnualouMensal
                );

            var calcJurosSimples = new CalcJurosSimples(
                jurosSimples.CapitalInicial,
                taxaDeJuros,
                jurosSimples.TempoMeses
                );

            var result = calcJurosSimples.CalcularJurosSimples();

            return Ok(result.ToString("f2"));
        }
    }
}
