using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Output.JurosSimples
{
    public class JurosSimplesOutput
    {

        public double ValorInicial { get; set; }

        public double TotalemJuros { get; set; }

        public double ValorTotalFinal { get; }

        public JurosSimplesOutput(double valorInicial, double totalEmJuros)
        {

            ValorInicial = valorInicial;
            TotalemJuros = totalEmJuros;
            ValorTotalFinal = ValorInicial + TotalemJuros;
        }

    }
}
