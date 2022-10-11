using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeZezinho = 17;
        int qtdPessoas = 2;

        if (idadeZezinho >= 18) //if: condição "se"
        {
            Console.WriteLine("Liberado!");
        }
        else //else: condição "se não"
        {
            if (qtdPessoas > 0)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Barrado!");
            }
        }

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}