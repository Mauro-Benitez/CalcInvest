using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Output.JurosCompostos
{
    public class JurosCompostosOutput
    {
        public double ValorTotalInvestido { get; set; }

        public double TotalemJuros { get; set; }

        public double ValorTotalFinal { get; }

        public JurosCompostosOutput(double valorTotalInvestido, double totalemJuros, double valorTotalFinal)
        {
            ValorTotalInvestido = valorTotalInvestido;
            TotalemJuros = totalemJuros;
            ValorTotalFinal = valorTotalFinal;
        }
    }
}
