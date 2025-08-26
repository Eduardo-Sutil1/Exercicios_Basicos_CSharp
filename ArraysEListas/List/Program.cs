using System;

namespace ListaNomes_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string> { "Ana", "Carlos", "Beatriz", "João", "Mariana" };

            Console.WriteLine("Lista de nomes:");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nAdicionando mais uma pessoa na lista: Eduardo");
            nomes.Add("Eduardo");

            Console.WriteLine("\nRemovendo uma pessoa da lista: Ana");
            nomes.Remove("Ana");

            Console.WriteLine("\nMostrando a lista atualizada:");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            int QuantidadeLista = nomes.Count();
            Console.WriteLine($"\nTem {QuantidadeLista} nomes na lista.");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}