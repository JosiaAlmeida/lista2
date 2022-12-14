using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc3
{
    public class DataDifference
    {
        private int[] diasDoMes = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private DateTime dataInicial;
        private DateTime dataFinal;
        public DataDifference(DateTime d1, DateTime d2)
        {
            int incremento;
            if (d1 > d2)
            {
                this.dataInicial = d2;
                this.dataFinal = d1;
            }
            else
            {
                this.dataInicial = d1;
                this.dataFinal = d2;
            }
            incremento = 0;
            if (this.dataInicial.Day > this.dataFinal.Day)
            {
                incremento = this.diasDoMes[this.dataInicial.Month - 1];
            }
            if (incremento == -1)
            {
                if (DateTime.IsLeapYear(this.dataInicial.Year))
                {
                    incremento = 29;
                }
                else
                {
                    incremento = 28;
                }
            }
            if (incremento != 0)
            {
                Dias = (this.dataFinal.Day + incremento) - this.dataInicial.Day;
                incremento = 1;
            }
            else
            {
                Dias = this.dataFinal.Day - this.dataInicial.Day;
            }
            if ((this.dataInicial.Month + incremento) > this.dataFinal.Month)
            {
                this.Meses = (this.dataFinal.Month + 12) - (this.dataInicial.Month + incremento);
                incremento = 1;
            }
            else
            {
                this.Meses = (this.dataFinal.Month) - (this.dataInicial.Month + incremento);
                incremento = 0;
            }
            this.Anos = this.dataFinal.Year - (this.dataInicial.Year + incremento);
        }
        public override string ToString()
        {
            return this.Anos + " Anos(s), " + this.Meses + " mes(es), " + this.Dias + " dia(s)";
        }
        public int Anos { get; }
        public int Meses { get; }
        public int Dias { get; }
    }
}
