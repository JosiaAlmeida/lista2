using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc7
{
    public class Primo
    {
        public List<double> Primos(double value)
        {
            int count = 0;
            List<double> list = new List<double>();
            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count > 2)
                {
                    count = 0;
                }
                else
                {
                    count = 0;
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
