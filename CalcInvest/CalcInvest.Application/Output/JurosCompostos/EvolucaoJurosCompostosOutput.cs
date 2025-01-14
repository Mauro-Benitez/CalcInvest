using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Output.JurosCompostos
{
    public class EvolucaoJurosCompostosOutput
    {
        public int Mes{ get; set; }
        public decimal TotalInvestido { get; set; }
        public decimal Juros { get; set; }       
        public decimal TotalJuros { get; set; }
        public decimal TotalAcumulado { get; set; }


    }
}
