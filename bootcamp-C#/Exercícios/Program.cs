// Exercício 1 - Condições
// Console.WriteLine("Olá, qual seu nome:");
// string aluno = Console.ReadLine();

// Console.WriteLine(aluno + " digite a nota do 1° trimestre:");
// int nota1 = int.Parse(Console.ReadLine());

// Console.WriteLine(aluno + " agora digite a nota do 2° trimestre:");
// int nota2 = int.Parse(Console.ReadLine());

// Console.WriteLine(aluno + " por fim digite a nota do 3° trimestre:");
// int nota3 = int.Parse(Console.ReadLine());

// int soma = (nota1 + nota2 + nota3) / 3;

// if(soma >= 6)
// {
//     Console.WriteLine(aluno + " você passou, meus parabéns!");
// }
// else if(soma >= 4)
// {
//     Console.WriteLine(aluno + " ,infelizmente você ficou de recuperação!" );
// }
// else 
// {
//     Console.WriteLine(aluno + " infelizmente você reprovou!");
// }

// Exercício 2 - Comparação OR
// bool maiorDeIdade = false;
// bool possuiAutorizacao = true;

// if (maiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada permitida");
// }
// else
// {
//     Console.WriteLine("Entrada não permitida");
// }

//  Exercício 3 - Comparação AND
// bool presencaMinima = true;
// double media = 7.5;

// if (presencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else 
// {
//     Console.WriteLine("Reprovado");
// }

// Exercício 4 - Comparação NOT
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }

// Exercício 5 - Estruturas de repetição for
// Console.WriteLine("Digite um número:");
// int numero = int.Parse(Console.ReadLine());

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine(numero + " X " + contador + " = " + numero * contador);
// }

// Exercício 6 - Estruturas de repetição while
// int numero = 0;
// int soma = 0;

// Console.WriteLine("Digite uma sequência de números e aperte enter (0 para sair)");
// numero = int.Parse(Console.ReadLine());

// while(numero != 0)
// {
//     soma = soma + numero;
//     numero = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("A soma dos números é:" + soma);

// Exercício 7 - Estruturas de repetição do while
// int numero = 0;
// int soma = 0;

// Console.WriteLine("Digite uma sequência de números e aperte enter (0 para sair)");

// do
// {
//     numero = int.Parse(Console.ReadLine());
//     soma = soma + numero;
// } while(numero != 0);

// Console.WriteLine("A soma dos números é:" + soma);

// Exercício 8 - Operadores aritméticos
// int numero1 = 0;
// int numero2 = 0;
// int resultado = 0;
// string operador;

// Console.WriteLine("Digite o 1° número:");
// numero1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o 2° número:");
// numero2 = int.Parse(Console.ReadLine());    

// Console.WriteLine(@"Digite a operação
// (+) - Adição
// (-) - Subtração
// (*) - Multiplicação
// (/) - Divisão");

// operador = Console.ReadLine();

// switch(operador)
// {
//     case "+":
//     resultado = numero1 + numero2;
//     break;

//     case "-":
//     resultado = numero1 - numero2;
//     break;

//     case "*":
//     resultado = numero1 * numero2;
//     break;

//     case "/":
//     resultado = numero1 / numero2;
//     break;

//     default:
//     Console.WriteLine("Opção inválida");
//     break;
// }

// Console.WriteLine(numero1 + " " + operador + " " + numero2 + " " + " = " + resultado);