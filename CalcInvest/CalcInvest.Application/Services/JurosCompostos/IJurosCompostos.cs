using CalcInvest.Application.Output.JurosCompostos;
using CalcInvest.Application.Output.JurosSimples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Services.JurosCompostos
{
    public interface IJurosCompostos
    {
        public JurosCompostosOutput CalcularJurosCompostos(JurosCompostosDTO jurosCompostsDTO);

        public List<EvolucaoJurosCompostosOutput> EvolucaoJuros(JurosCompostosDTO jurosCompostsDTO);


    }
}
