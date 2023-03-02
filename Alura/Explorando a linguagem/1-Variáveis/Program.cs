using System;
class Programa
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Variáveis");

        int idade;

        idade = 18;

        Console.WriteLine("Minha idade é: " + idade); 
        idade = 18 - 4;

        Console.WriteLine(idade);
        idade = 4 * 2 - 6;

        Console.WriteLine(idade);
        idade = (4 - 2) * 3;

        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}