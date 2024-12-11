using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Core
{
    public class TaxaDeJuros
    {
        public double Porcentagem { get; set; }
        public int TempoMeses { get; set; }

        public TaxaDeJuros(double porcentagem, int meses) 
        {

            TempoMeses = meses;

            Porcentagem = porcentagem;
        }
    }
}
