using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDoTriangulo
{
    public class Triangulo
    {
        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public double CalcularArea()
        {
            double area = 0, p = 0;

            p = (LadoA + LadoB + LadoC) / 2;
            area = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));

            return area;
        }
    }
}
