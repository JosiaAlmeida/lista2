using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6
{
    public class Soma
    {
        public string calcSoma(string value)
        {
            string result = "";
            double soma = 0;
            foreach (var item in value)
            {
                if (result == "")
                {
                    result = item.ToString();
                    soma = Double.Parse(result);
                }
                else
                {
                    result = result + " + " + item.ToString();
                    soma =soma + Double.Parse(item.ToString());
                }
            }
            return result +" = "+ soma.ToString();
        }
    }
}
