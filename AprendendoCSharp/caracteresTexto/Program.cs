using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(74 + 1);
        Console.Write(letra);

        letra = (char)(64 + 1);
        Console.Write(letra);

        letra = (char)(84 + 1);
        Console.Write(letra);

        letra = (char)(64 + 1);
        Console.Write(letra);

        letra = (char)(77 + 1);
        Console.WriteLine(letra);

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}