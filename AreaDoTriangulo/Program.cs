using System;
using System.Globalization;

namespace AreaDoTriangulo
{
    class Area_Do_Triangulo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado A:");
            double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do lado B:");
            double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do lado C:");
            double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var triangulo = new Triangulo(ladoA, ladoB, ladoC);

            Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}