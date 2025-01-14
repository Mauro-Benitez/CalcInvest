using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Output.JurosCompostos
{
    public class JurosCompostosOutput
    {
        public decimal ValorTotalInvestido { get; set; }

        public decimal JurosMensal { get; set; }

        public decimal TotalemJuros { get; set; }       

        public decimal ValorTotalFinal { get; }

        public JurosCompostosOutput(decimal valorTotalInvestido, decimal totalemJuros, decimal valorTotalFinal, decimal jurosMensal)
        {
            ValorTotalInvestido = Math.Round(valorTotalInvestido,2);
            TotalemJuros = Math.Round(totalemJuros, 2);
            ValorTotalFinal = Math.Round(valorTotalFinal, 2);
            JurosMensal = Math.Round(jurosMensal, 2);
        }
    }
}
