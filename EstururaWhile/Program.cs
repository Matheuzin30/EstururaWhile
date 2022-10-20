using System;
using System.Globalization;
    
    namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite Outro Número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número Negativo!");

        }
    }
}