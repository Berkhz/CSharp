using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Poupança");

        double investimento = 1000.00;

        // rendimento de 0.5% ao mês

        //mês 1
        //investimento = investimento + investimento * 0.005;
        //mês 2
        //investimento = investimento + investimento * 0.005;
        //mês 3
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você acumulou R$" + investimento);

            mes = mes + 1;
        }

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
} 