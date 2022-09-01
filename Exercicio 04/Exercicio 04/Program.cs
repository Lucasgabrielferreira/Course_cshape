using System;
using System.Globalization;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("AREA = " + ret.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + ret.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
