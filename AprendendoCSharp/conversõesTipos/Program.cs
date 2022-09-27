using System;

class Programa
{  
    static void Main(string[] args) 
    {   
        double salario = 783.01; // double: é a variável que recebe numéro quebrado
        Console.WriteLine("Seu salário é: R$" + salario);

        int salarioInteiro = (int)salario; // (int)salario: guarda a váriavel salário dentro de um número inteiro
        Console.WriteLine("Seu salário inteiro: R$" + salarioInteiro);

        long x = 100000; // long: é a variavel de 64 bits que armazena um número maior de caracteres 
        Console.WriteLine("Seu saldo bancário: R$" + x);

        short y = 1000; // short: contrário do long o short armazena pequenos caracteres na variável
        Console.WriteLine("Seu aluguel: R$" + y);

        float altura = 1.70f; 
        Console.WriteLine("Sua altura: " + altura + "cm");
                                                            
        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}