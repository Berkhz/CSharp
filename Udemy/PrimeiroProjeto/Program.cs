using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Início
            Console.WriteLine("Olá!");
            Console.WriteLine("Bom dia!");

            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais.");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais.");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            // Processamento de dados
            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);

            // Entrada de dados
            Console.WriteLine("Insira uma frase: ");

            string frase = Console.ReadLine();
            string a = Console.ReadLine();
            string e = Console.ReadLine();
            string i = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Frase digitada: ");

            Console.WriteLine(frase);
            Console.WriteLine(a);
            Console.WriteLine(e);
            Console.WriteLine(i);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet1 = Console.ReadLine().Split(' ');
            string nome = vet1[0];
            char sexo = char.Parse(vet1[1]);
            int idade = int.Parse(vet1[2]);
            double altura = double.Parse(vet1[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: " + n1);
            Console.WriteLine("Você digitou: " + ch);
            Console.WriteLine("Você digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome + " \n" + sexo + " \n" + idade + " \n" + altura.ToString("F2", CultureInfo.InvariantCulture));

            // Exercício Proposto

            Console.WriteLine("Qual o seu nome Completo?");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em sua casa?");
            int numeroQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de um produto qualquer:");
            double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Por fim, escreva seu último nome, sua idade e sua altura!");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimoNome = vetor[0];
            int idadePessoa = int.Parse(vetor[1]);
            double alturaPessoa = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(valorProduto.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome + " \n" + idadePessoa + " \n" + alturaPessoa.ToString(CultureInfo.InvariantCulture));

            // Funções matemáticas C#
            double x1 = 3.0;
            double y2 = 4.0;
            double z3 = -5.0;
            double A, B1, C;

            A = Math.Sqrt(x1); // Raiz quadrada
            B1 = Math.Sqrt(y2);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x1 + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y2 + " = " + B1);
            Console.WriteLine("Raiz quadrada de 25 =" + C);

            A = Math.Pow(x1, y2); // Potência
            B1 = Math.Pow(x1, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x1 + " elevado a " + y + " = " + A);
            Console.WriteLine(x1 + " elevado ao quadrado = " + B1);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(y); // Valor absoluto
            B1 = Math.Abs(z3);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z3 + " = " + B1);

            Console.ReadLine();
            // Exercício concluído
        }
    }
}