using CalcInvest.Application.Output;
using CalcInvest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Services
{
    public class JurosSimplesService : IJurosSimples
    {
        public JurosSimplesOutput CalcularJurosSimples(JurosSimplesDTO jurosSimples)
        {            

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

            var output = new JurosSimplesOutput(jurosSimples.CapitalInicial, result);

            
            return output;

            
        }
    }
}
