using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação (+, -, *, /):");
            char operador = char.Parse(Console.ReadLine());

            double resultado;

            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case '-':
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case '*':
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case '/':
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}