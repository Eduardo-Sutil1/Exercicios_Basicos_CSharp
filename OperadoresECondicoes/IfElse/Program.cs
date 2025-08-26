using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê a entrada do usuário e converte diretamente para int
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é PAR.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ÍMPAR.");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}