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
        public double Juros { get; set; }
        public double TotalInvestido { get; set; }
        public double TotalJuros { get; set; }
        public double TotalAcumulado { get; set; }


    }
}
