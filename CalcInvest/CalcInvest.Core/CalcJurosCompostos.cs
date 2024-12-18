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

        public double ValorFinal { get; set; }

        public CalcJurosCompostos(double capitalInicial, double valorMensal, TaxaDeJuros taxaDeJuros, int tempoMeses)
        {
            CapitalInicial = capitalInicial;
            ValorMensal = valorMensal;
            TaxaDeJuros = taxaDeJuros;
            TempoMeses = tempoMeses;
           
        }

        public double CalcularJurosCompostos()
        {
            if (TaxaDeJuros.Tipo == "Mensal" || TaxaDeJuros.Tipo == "mensal")
            {
                 double taxaDeJuros = TaxaDeJuros.Porcentagem/100;


                double MontanteIncial = CapitalInicial * Math.Pow(1 + taxaDeJuros, TempoMeses);

                double MontanteAportes = CapitalInicial * (Math.Pow(1 + taxaDeJuros, TempoMeses) - 1) / taxaDeJuros;



                return MontanteIncial * MontanteAportes;
            }


            return 0;
        }




    }
}
