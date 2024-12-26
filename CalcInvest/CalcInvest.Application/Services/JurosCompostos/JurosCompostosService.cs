using CalcInvest.Application.Output.JurosCompostos;
using CalcInvest.Application.Output.JurosSimples;
using CalcInvest.Application.Services.JurosSimples;
using CalcInvest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Services.JurosCompostos
{
    public class JurosCompostosService : IJurosCompostos
    {
        public JurosCompostosOutput CalcularJurosCompostos(JurosCompostosDTO jurosCompostsDTO)
        {
            var taxaDeJuros = new TaxaDeJuros(
               jurosCompostsDTO.TaxaDeJuros,
               jurosCompostsDTO.AnualouMensal
           );

            var calcJurosCompostos = new CalcJurosCompostos(
                jurosCompostsDTO.CapitalInicial,
                taxaDeJuros,
                jurosCompostsDTO.ValorMensal,
                jurosCompostsDTO.TempoMeses
            );

            var result = calcJurosCompostos.CalcularJurosCompostos();

            var output = new JurosCompostosOutput(calcJurosCompostos.ValorTotalInvestido, result, calcJurosCompostos.ValorTotalFinal);

            return output;
        }

        public List<EvolucaoJurosCompostosOutput> EvolucaoJuros(JurosCompostosDTO jurosCompostsDTO)
        {
            throw new NotImplementedException();
        }
    }
}
