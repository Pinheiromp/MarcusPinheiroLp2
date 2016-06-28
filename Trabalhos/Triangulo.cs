using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    public class Triangulo
    {
        private double _ladoA;
        public double ladoA
        {
            get { return _ladoA; }
            set
            {
                if (value > 0)
                    _ladoA = value;
            }
        }
        private double _ladoB;
        public double ladoB
        {
            get { return _ladoB; }
            set
            {
                if (value > 0)
                    _ladoB = value;
            }
        }
        private double _ladoC;
        public double ladoC
        {
            get { return _ladoC; }
            set
            {
                if (value > 0)
                    _ladoC= value;
            }
        }
        public int Id {get; set;}
        public int parx { get; set; }
        public int pary { get; set; }
        private int _cor;
        public int Cor
        {
            get { return _cor; }
            set
            {
                if (value >= 0 && value <= (Math.Pow(2, 24) - 1))
                    _cor = value;
            }
        }

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            if (ladoA > 0 && ladoB > 0 && ladoC > 0)
                if ((ladoA + ladoB) > ladoC || (ladoB + ladoC) > ladoA || (ladoA + ladoC) > ladoB)
                {
                    this.ladoA = ladoA;
                    this.ladoB = ladoB;
                    this.ladoC = ladoC;
                }
        }
    }
}
