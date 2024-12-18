using CalcInvest.Application;
using CalcInvest.Application.Output.JurosSimples;
using CalcInvest.Application.Services.JurosSimples;
using CalcInvest.Core;
using CalcInvest.Core.Enum;
using Microsoft.AspNetCore.Mvc;

namespace CalcInvest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosSimplesController : Controller
    {

        private readonly IJurosSimples _JurosSimples;

        public JurosSimplesController(IJurosSimples jurosSimples)
        {
            _JurosSimples = jurosSimples;
        }

        [HttpPost("Calcular")]
        [ProducesResponseType(StatusCodes.Status200OK)]        
        public ActionResult JurosSimples([FromBody] JurosSimplesDTO jurosSimples)
        {
            if (jurosSimples == null) return BadRequest();

            var result = _JurosSimples.CalcularJurosSimples(jurosSimples);

            return Ok(result);
        }



        [HttpPost("EvolucaoJuros")]
        [ProducesResponseType(StatusCodes.Status200OK)]        
        public ActionResult<List<EvolucaoJurosSimplesOutput>> JurosSimplesEvolucao([FromBody] JurosSimplesDTO jurosSimples)
        {
            if (jurosSimples == null) return BadRequest();

            var evolution = _JurosSimples.EvolucaoJuros(jurosSimples, jurosSimples.TempoMeses);

            return Ok(evolution);
        }
    }
}
