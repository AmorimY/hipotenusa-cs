using System;

namespace Hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro cateto:");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo cateto:");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));

            Console.WriteLine("A hipotenusa é " + hipotenusa);
                

        }
    }
}