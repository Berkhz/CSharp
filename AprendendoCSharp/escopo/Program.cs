using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais");

        int idadeZezinho = 17;
        int qtdPessoas = 2;

        bool acompanhado = qtdPessoas > 1;

        string textoAdicional;

        if (acompanhado == true) 
        {
            textoAdicional = "Ele está acompanhado!";
        }
        else
        {
            textoAdicional = "Ele não está acompanhado!";
        }

        if (idadeZezinho >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
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