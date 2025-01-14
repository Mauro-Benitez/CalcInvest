using CalcInvest.Application.Output.JurosCompostos;
using CalcInvest.Application.Output.JurosSimples;
using CalcInvest.Application.Services.JurosSimples;
using CalcInvest.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

            var toalemJuros = calcJurosCompostos.CalcularJurosCompostos();

            var output = new JurosCompostosOutput(calcJurosCompostos.ValorTotalInvestido, toalemJuros, calcJurosCompostos.ValorTotalFinal, calcJurosCompostos.JurosMensal);

            return output;
        }

        public List<EvolucaoJurosCompostosOutput> EvolucaoJuros(JurosCompostosDTO jurosCompostsDTO, int meses)
        {
            var result = new List<EvolucaoJurosCompostosOutput>();
            for (int i = 1; i <= meses; i++)
            {
                jurosCompostsDTO.TempoMeses = i;
                var jurosCompostos = CalcularJurosCompostos(jurosCompostsDTO);


                result.Add(
                    new EvolucaoJurosCompostosOutput
                    {
                        Mes = i,
                        TotalInvestido = jurosCompostos.ValorTotalInvestido,
                        Juros = jurosCompostos.JurosMensal,                        
                        TotalAcumulado = jurosCompostos.ValorTotalFinal,
                        TotalJuros = jurosCompostos.TotalemJuros
                    });
            }
            return result;
        }
    }
}
