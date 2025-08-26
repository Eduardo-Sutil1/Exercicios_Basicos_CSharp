using System;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            string status = idade >= 18 ? "Maior de idade" : "Menor de idade";

            Console.WriteLine($"Você é {status}.");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}