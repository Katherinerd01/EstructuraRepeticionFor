using System;

namespace RepeticionFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números deseas ingresar? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int contador = 0;
            for (int i = 0; i < n; i++)            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 1000)
                {
                    contador++;
                }
            }

            Console.WriteLine($"La cantidad de números mayores o iguales a 1000 es: {contador} ");

            Console.ReadKey();
        }
    }
}
    





 