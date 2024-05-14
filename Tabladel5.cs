using System;

namespace Tabla5al50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de multiplicar del 5:");

            for (int f = 1; f <= 10; f++)
            {
                int multiplicacion = f * 5;
                Console.WriteLine($"5 x {f} = {multiplicacion} ");
            }
            Console.ReadKey();
        }
    }
}
    