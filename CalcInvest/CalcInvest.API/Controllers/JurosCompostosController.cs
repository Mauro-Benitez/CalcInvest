using CalcInvest.Application.Services.JurosSimples;
using CalcInvest.Application;
using Microsoft.AspNetCore.Mvc;
using CalcInvest.Core;
using CalcInvest.Application.Services.JurosCompostos;
using CalcInvest.Application.Output.JurosSimples;
using CalcInvest.Application.Output.JurosCompostos;

namespace CalcInvest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JurosCompostosController : Controller
    {
        private readonly IJurosCompostos _JurosCompostos;

        public JurosCompostosController(IJurosCompostos jurosCompostos)
        {
            _JurosCompostos = jurosCompostos;
        }

        [HttpPost("Calcular")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult JurosCompostos([FromBody] JurosCompostosDTO jurosCompostos)
        {
            if (jurosCompostos == null) return BadRequest();          

            var result = _JurosCompostos.CalcularJurosCompostos(jurosCompostos);

            return Ok(result);
        }

        [HttpPost("EvolucaoJuros")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<EvolucaoJurosCompostosOutput>> JurosSimplesEvolucao([FromBody] JurosCompostosDTO jurosCompostos)
        {
            if (jurosCompostos == null) return BadRequest();

            var evolution = _JurosCompostos.EvolucaoJuros(jurosCompostos, jurosCompostos.TempoMeses);

            return Ok(evolution);
        }




    }
}
