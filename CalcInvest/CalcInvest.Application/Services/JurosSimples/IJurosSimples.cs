using CalcInvest.Application.Output.JurosSimples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Services.JurosSimples
{
    public interface IJurosSimples
    {
        public JurosSimplesOutput CalcularJurosSimples(JurosSimplesDTO jurosSimplesDTO);

        public List<EvolucaoJurosSimplesOutput> EvolucaoJuros(JurosSimplesDTO jurosSimplesDTO, int meses);


    }
}
