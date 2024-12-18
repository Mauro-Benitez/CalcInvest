using CalcInvest.Application.Services.JurosSimples;
using CalcInvest.Application;
using Microsoft.AspNetCore.Mvc;
using CalcInvest.Core;

namespace CalcInvest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosCompostosController : Controller
    {

        [HttpPost("Calcular")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult JurosCompostos([FromBody] JurosCompostoDTO jurosCompostos)
        {
            if (jurosCompostos == null) return BadRequest();


            var taxadeJuros = new TaxaDeJuros(jurosCompostos.TaxaDeJuros, jurosCompostos.AnualouMensal);

            var jurosCompoto = new CalcJurosCompostos(
                jurosCompostos.CapitalInicial,
                jurosCompostos.ValorMensal,
                taxadeJuros,
                jurosCompostos.TempoMeses
                );

            var result = jurosCompoto.CalcularJurosCompostos();

            return Ok(result);
        }
    }
}
