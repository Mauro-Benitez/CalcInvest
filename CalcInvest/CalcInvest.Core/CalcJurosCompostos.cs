using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Core
{
    public class CalcJurosCompostos
    {
        public double CapitalInicial { get; set; } 
        public double ValorMensal { get; set; }
        public TaxaDeJuros TaxaDeJuros { get; set; }
        public int TempoMeses { get; set; }
        public double ValorTotalFinal { get; set; }
        public double ValorTotalInvestido { get; set; }             


        public CalcJurosCompostos(double capitalInicial, TaxaDeJuros taxaDeJuros, double valorMensal,  int tempoMeses)
        {
            CapitalInicial = capitalInicial;
            ValorMensal = valorMensal;
            TaxaDeJuros = taxaDeJuros;
            TempoMeses = tempoMeses;
           
        }

        public double CalcularJurosCompostos()
        {
            double taxaDeJurosFinal;
            if (TaxaDeJuros.Tipo == "Mensal" || TaxaDeJuros.Tipo == "mensal")
            {
                taxaDeJurosFinal = TaxaDeJuros.Porcentagem / 100;                
            }
            else
            {               
                taxaDeJurosFinal = Math.Pow(1 + TaxaDeJuros.Porcentagem / 100, 1.0 / 12) - 1;
            }

            double montante = CapitalInicial;
            double totalInvestido = CapitalInicial;

            for (int i = 0; i < TempoMeses; i++)
            {
                montante += montante * taxaDeJurosFinal;
                montante += ValorMensal;
                totalInvestido += ValorMensal;
            }
            
            ValorTotalInvestido = totalInvestido;
            ValorTotalFinal = montante;
            return montante - totalInvestido;

        }




    }
}
