using System;
using System.Data;

namespace TiposEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string: texto
            string nome = "Eduardo";

            // int: número inteiro
            int idade = 22;

            // double: número com casas decimais (alta precisão)
            double altura = 1.73;

            // float: número com casas decimais (precisão menor que double)
            float peso = 69.5f;

            // decimal: usado geralmente para valores financeiros
            decimal saldobancario = 1150.75m;

            // bool: verdadeiro ou falso
            bool temCarteiraDeMotorista = true;

            // char: um único caractere
            char inicialDoNome = 'E';

            // DateTime: data e hora
            DateTime dataAtual = DateTime.Now;

            //Exibir os valores
            Console.WriteLine("Informações do usuário: ");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Altura: {altura}cm");
            Console.WriteLine($"Peso: {peso}kg");
            Console.WriteLine($"Saldo bancário: R$ {saldobancario}");
            Console.WriteLine($"Possui carteira de motorista? {temCarteiraDeMotorista}");
            Console.WriteLine($"Inicial do nome: {inicialDoNome}");
            Console.WriteLine($"Data atual: {dataAtual}");
        }
    }
}