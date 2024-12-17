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

        public List<EvolucaoJurosSimplesOutput> EvolucaoJuros(JurosSimplesDTO jurosSimplesDTO, int meses)
        {
            var result = new List<EvolucaoJurosSimplesOutput>();

            for (int i = 1; i <= meses; i++)
            {
                jurosSimplesDTO.TempoMeses = i;
                var jurosSimples = CalcularJurosSimples(jurosSimplesDTO);
                var valorTotal = jurosSimplesDTO.CapitalInicial + jurosSimples.TotalemJuros;

                result.Add(
                    new EvolucaoJurosSimplesOutput
                    {
                        TempoMeses = i,
                        JurosAcumulados = jurosSimples.TotalemJuros,
                        Total = valorTotal
                    });


            }

            return result;

        }
    }
}
