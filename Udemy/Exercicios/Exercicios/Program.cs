using System;
using System.Globalization;

namespace Exercicios
{
    public class Exercicio1001
    {
        public static void Executar()
        {
            // Exercício 1001
            // Soma de dois números
            int A, B, X;

            Console.WriteLine("Realizando a soma de dois números!");
            Console.WriteLine("Valor de A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B:");
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);
        }
    }

    public class Exercicio1002
    {
        public static void Executar()
        {
            // Exercício 1002
            // Área círculo
            double area, pi, raio;

            Console.WriteLine("Descobrindo a área do círculo!");
            Console.WriteLine("Qual o valor do raio?");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pi = 3.14159;
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Área=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }

    public class Exercicio1003
    {
        public static void Executar()
        {
            // Exercício 1003
            // Soma simples
            int SOMA, A, B;

            Console.WriteLine("Valor de A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B:");
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }

    public class Exercicio1004
    {
        public static void Executar()
        {
            // Exercício 1004
            // Cálculo produto de dois valores

            double PROD;
            int v1, v2;

            Console.WriteLine("Primeiro valor: ");
            v1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Segundo valor: ");
            v2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            PROD = v1 * v2;

            Console.WriteLine("O produto dos valores: " + v1 + " * " + v2 + " = " + PROD);
        }
    }

    public class Exercicio1005
    {
        public static void Executar()
        {
            // Exercício 1005
            // Média

            double A, B, media;

            Console.WriteLine("Primeira nota (PESO = 3,5)");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Segunda nota (PESO = 7,5)");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11.0;

            Console.WriteLine("Sua média é de: " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }

    public class Exercicio1006
    {
        public static void Executar()
        {
            // Exercício 1006
            // Média 2

            double A, B, C, media;

            Console.WriteLine("Primeira nota (PESO = 2,0)");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Segunda nota (PESO = 3,0)");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Terceira nota (PESO = 5,0)");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

            Console.WriteLine("MÉDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

    public class Exercicio1007
    {
        public static void Executar()
        {
            // Exercício 1007
            // Diferença
            int A, B, C, D, dif;

            Console.WriteLine("Valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de D: ");
            D = int.Parse(Console.ReadLine());

            dif = (A * B - C * D);

            Console.WriteLine("DIFERENÇA = " + dif);
        }
    }

    public class Exercicio1008
    {
        public static void Executar()
        {
            // Exercício 1008
            // Cálculo de salário

            int numeroFuncionario, horasTrabalhadas;
            double salario;

            Console.WriteLine("Número do funcionário: ");
            numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário do funcionário (Por hora trabalhada): ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = salario * horasTrabalhadas;

            Console.WriteLine("Número funcionário: " + numeroFuncionario);
            Console.WriteLine("Salário: R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    public class Exercicio1010
    {
        public static void Executar()
        {
            // Exercício 1010
            // Cálculo simples

            int qtdProduto1, qtdProduto2, codigoProduto1, codigoProduto2;
            double valorProduto1, valorProduto2, total;

            Console.WriteLine("Código, Quantidade e Valor do Produto: ");

            string[] valores = Console.ReadLine().Split(' ');
            codigoProduto1 = int.Parse(valores[0]);
            qtdProduto1 = int.Parse(valores[1]);
            valorProduto1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigoProduto2 = int.Parse(valores[0]);
            qtdProduto2 = int.Parse(valores[1]);
            valorProduto2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = (valorProduto1 * qtdProduto1) + (valorProduto2 * qtdProduto2);

            Console.WriteLine("Valor a ser pago = R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    public class Exercicio1014
    {
        public static void Executar()
        {
            // Exercício 1014
            // Consumo carro

            int x; // Quilômetros
            double y, kml; // Litros e total (kml)

            Console.WriteLine("Distância percorrida: (Km)");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Litros abastecidos: (l)");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kml = x / y;

            Console.WriteLine("Média de consumo: " + kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }

    public class Exercicio1016
    {
        public static void Executar()
        {
            // Exercício 1016
            // Distância

            int distancia, tempo;

            Console.WriteLine("Distância percorrida");
            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }

    public class Exercicio1017
    {
        public static void Executar()
        {
            // Exercício 1016
            // Gasto de combustível

            int tempoGasto, velocidadeMedia, distancia;
            double litros;

            Console.WriteLine("Tempo gasto na viagem: ");
            tempoGasto = int.Parse(Console.ReadLine());
            Console.WriteLine("Velocidade média (em km/h)");
            velocidadeMedia = int.Parse(Console.ReadLine());

            distancia = tempoGasto * velocidadeMedia;

            // aqui eh importante colocar o .0 depois do 12, ou entao fazer o casting (double)
            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual exercício deseja executar? ");
            string exercicio = Console.ReadLine();

            switch (exercicio)
            {
                case "1001":
                    Exercicio1001.Executar();
                    break;
                case "1002":
                    Exercicio1002.Executar();
                    break;
                case "1003":
                    Exercicio1003.Executar();
                    break;
                case "1004":
                    Exercicio1004.Executar();
                    break;
                case "1005":
                    Exercicio1005.Executar();
                    break;
                case "1006":
                    Exercicio1006.Executar();
                    break;
                case "1007":
                    Exercicio1007.Executar();
                    break;
                case "1008":
                    Exercicio1008.Executar();
                    break;
                case "1010":
                    Exercicio1010.Executar();
                    break;
                case "1014":
                    Exercicio1014.Executar();
                    break;
                case "1016":
                    Exercicio1016.Executar();
                    break;
                case "1017":
                    Exercicio1017.Executar();
                    break;
                default:
                    Console.WriteLine("Exercício não encontrado!");
                    break;
            }

            Console.ReadLine();
            // Exercício concluído
        }
    }
}