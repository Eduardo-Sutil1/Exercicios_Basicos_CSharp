using System;

namespace NumerosPares_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números pares de 1 a 100:");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                }
            }

            Console.WriteLine("\n\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}