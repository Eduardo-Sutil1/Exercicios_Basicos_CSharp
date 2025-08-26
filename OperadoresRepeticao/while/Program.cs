using System;

namespace ContagemRegressiva_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 10;

            Console.WriteLine("Contagem regressiva:");

            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;
            }

            Console.WriteLine("FIM!");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}