using System;

namespace BaseyAlturaDeUnTriangulo
{
     class Program
    {
        static void Main(string[] args)
        {
            int basetriangulo, altura, superficie, cantidad, f, n;
            string linea;
            cantidad = 0;

            Console.Write("¿Cuántos Triángulos ingresaras? ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for (f = 1; f <= n; f++)
            {
                Console.Write("Ingrese la Base: ");
                linea = Console.ReadLine();
                basetriangulo = int.Parse(linea);
                Console.Write("Ingrese la Altura: ");
                linea = Console.ReadLine();
                altura = int.Parse(linea);
                superficie = basetriangulo * altura / 2;
                Console.Write("La Superficie del Triángulo es: ");
                Console.WriteLine(superficie);
                if (superficie > 12);
                {
                    cantidad++;
                }
                Console.Write("La cantidad de triángulos cuya superficie es mayor a 12 es: ");
                Console.WriteLine(cantidad);
                Console.ReadKey();

            }
        }
    }
}
