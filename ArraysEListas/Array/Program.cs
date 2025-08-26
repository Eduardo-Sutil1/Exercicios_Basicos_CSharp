using System;

namespace NotasAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = { 7.5, 8.0, 6.5, 9.0, 7.0 };
            double soma = 0;

            foreach (double nota in notas)
            {
                soma += nota;
            }

            double media = soma / notas.Length;

            Console.WriteLine("Notas dos alunos: ");
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine($"\nMédia das notas: {media:F2}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}