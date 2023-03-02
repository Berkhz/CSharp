using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Poupança 2");

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você acumulou R$" + investimento);

            //mes = mes + 1;
            mes += 1;
        }
        */

        double investimento = 1000.00;

        for (int mes = 1; mes <= 12; mes = mes + 1) //laço de repetição for
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você acumulou R$" + investimento);
        }

        Console.WriteLine("Pressione enter para sair...");
        Console.ReadLine();
    }
}