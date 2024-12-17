using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Output
{
    public class EvolucaoJurosSimplesOutput
    {

        public int TempoMeses { get; set; } 
        public double JurosAcumulados { get; set; } // Juros acumulados até o período
        public double Total { get; set; } // Montante total no período



    }
}
