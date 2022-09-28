using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a'; //char: guarda um caracter da tabela ascii
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

        string primeiraFrase = "Primeira variável string"; //string: recebe caracteres na sua variável
        Console.WriteLine(primeiraFrase);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Curso de C#: 
        - Introdução
        - Aprendendo a Linguagem
        - Primeiro Projeto"; //@: permite listar os itens na string

        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}