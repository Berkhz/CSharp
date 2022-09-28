using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeZezinho = 17;
        int qtdPessoas = 2;

        bool acompanhado = qtdPessoas > 1;
        bool grupo = true;

        if (idadeZezinho >= 18 || grupo)
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