Console.WriteLine("Olá, qual seu nome:");
string aluno = Console.ReadLine();

Console.WriteLine(aluno + " digite a nota do 1° trimestre:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine(aluno + " agora digite a nota do 2° trimestre:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine(aluno + " por fim digite a nota do 3° trimestre:");
int nota3 = int.Parse(Console.ReadLine());

int soma = (nota1 + nota2 + nota3) / 3;

if(soma >= 6)
{
    Console.WriteLine(aluno + " você passou, meus parabéns!");
}
else if(soma >= 4)
{
    Console.WriteLine(aluno + " ,infelizmente você ficou de recuperação!" );
}
else 
{
    Console.WriteLine(aluno + " infelizmente você reprovou!");
}