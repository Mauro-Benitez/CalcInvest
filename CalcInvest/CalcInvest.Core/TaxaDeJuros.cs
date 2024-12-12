using CalcInvest.Core.Enum;
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
        public string Tipo { get; set; }      

        public TaxaDeJuros(double porcentagem, string tipo) 
        {
            Tipo = tipo;
            Porcentagem = porcentagem;
        }

     
    }
}
