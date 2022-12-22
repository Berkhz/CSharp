using System;

namespace ConsoleApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Lógica de programação C# em 10 minutos!
            // Variáveis 
            // Atribuir valor a elas
            // Estruturas condicionais

            int numero = 10; // Variável do tipo inteiro
            int numero_2 = 5;
            Console.WriteLine("Quanto é " + numero + " + " + numero_2 + "?");

            int resposta = Convert.ToInt32(Console.ReadLine());  // Utilizada biblioteca que converte tipo inteiro pra string.

            // Estrutura condicional

            if (resposta == 15)
            {
                Console.WriteLine("Parabéns! Você acertou!");
            } else
            {
                Console.WriteLine("Tente novamente!");
            }
        }
    }
}
