using CalcInvest.Application.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcInvest.Application.Services
{
    public interface IJurosSimples
    {
        public JurosSimplesOutput CalcularJurosSimples(JurosSimplesDTO jurosSimplesDTO);


    }
}
