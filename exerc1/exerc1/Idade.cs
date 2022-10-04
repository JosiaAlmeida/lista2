using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    public class Idade
    {
        public double calcIdadeAnos(double anoNasc, double anoActual)
        {
            return anoActual - anoNasc;
        }
        public double calcIdadeMes(double mesNasc, double mesActual, double idadeActual)
        {
            if (mesNasc < mesActual)
            {
                return mesNasc * idadeActual - (mesActual - mesNasc);
            }
            else if (mesNasc > mesActual)
            {
                return mesNasc * idadeActual - (mesNasc - mesActual);
            }
            else
            {
                return mesNasc * idadeActual;
            }
        }
        public double calcIdadeSemana(double idadeMes, double idadeAno)
        {
            return idadeMes * idadeAno;
        }
    }
}
