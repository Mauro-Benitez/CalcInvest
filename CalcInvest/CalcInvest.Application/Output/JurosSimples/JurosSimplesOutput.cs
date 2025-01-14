using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Output.JurosSimples
{
    public class JurosSimplesOutput
    {

        public decimal TotalInvestido { get; set; }

        public decimal TotalemJuros { get; set; }

        public decimal ValorTotalFinal { get; }

        public JurosSimplesOutput(decimal valorInicial, decimal totalEmJuros)
        {

            TotalInvestido = Math.Round(valorInicial,2);
            TotalemJuros = Math.Round(totalEmJuros, 2);
            ValorTotalFinal = Math.Round(TotalInvestido + TotalemJuros, 2);
             
        }

    }
}
