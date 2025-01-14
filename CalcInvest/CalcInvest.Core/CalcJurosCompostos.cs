using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Core
{
    public class CalcJurosCompostos
    {
        public decimal CapitalInicial { get; set; } 
        public decimal ValorMensal { get; set; }
        public TaxaDeJuros TaxaDeJuros { get; set; }
        public int TempoMeses { get; set; }
        public decimal JurosMensal { get; set; }
        public decimal ValorTotalFinal { get; set; }
        public decimal ValorTotalInvestido { get; set; }             


        public CalcJurosCompostos(decimal capitalInicial, TaxaDeJuros taxaDeJuros, decimal valorMensal,  int tempoMeses)
        {
            CapitalInicial = capitalInicial;
            ValorMensal = valorMensal;
            TaxaDeJuros = taxaDeJuros;
            TempoMeses = tempoMeses;
           
        }

        public decimal CalcularJurosCompostos()
        {
            decimal taxaDeJurosFinal;
            if (TaxaDeJuros.Tipo == "Mensal" || TaxaDeJuros.Tipo == "mensal")
            {
                taxaDeJurosFinal = TaxaDeJuros.Porcentagem / 100;                
            }
            else
            {               
                taxaDeJurosFinal = (decimal)Math.Pow(1 + Convert.ToDouble(TaxaDeJuros.Porcentagem) / 100, 1.0 / 12) - 1;
            }

            decimal totalAcumulado = 0;
            decimal totalInvestido = CapitalInicial;
            decimal totalJuros = 0;

            for (int i = 1; i <= TempoMeses; i++)
            {
                if (i > 0)
                {
                    totalInvestido += ValorMensal;
                }

                decimal jurosMensal = totalInvestido * taxaDeJurosFinal;
                totalJuros +=  jurosMensal;
                totalAcumulado = totalInvestido + totalJuros;
                JurosMensal = jurosMensal;


            }
            ValorTotalInvestido = totalInvestido;
            ValorTotalFinal = totalAcumulado;
            
            return totalAcumulado - totalInvestido;

        }




    }
}
