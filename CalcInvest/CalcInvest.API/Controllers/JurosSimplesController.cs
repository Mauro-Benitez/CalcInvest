using CalcInvest.Application;
using CalcInvest.Application.Output;
using CalcInvest.Application.Services;
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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Calc([FromBody] JurosSimplesDTO jurosSimples)
        {
            if (jurosSimples == null) return BadRequest();

            var result = _JurosSimples.CalcularJurosSimples(jurosSimples);

            return Ok(result);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<EvolucaoJurosSimplesOutput>> JurosSimplesEvolucao([FromBody] JurosSimplesDTO jurosSimples)
        {
            if (jurosSimples == null) return BadRequest();

            var evolution = _JurosSimples.EvolucaoJuros(jurosSimples, jurosSimples.TempoMeses);

            return Ok(evolution);
        }
    }
}
