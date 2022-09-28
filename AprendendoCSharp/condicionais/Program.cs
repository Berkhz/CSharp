using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeZezinho = 17;

        if (idadeZezinho >= 18)
        {
            Console.WriteLine("Liberado!");
        }
        else
        {
            Console.WriteLine("Barrado!");
        }

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}