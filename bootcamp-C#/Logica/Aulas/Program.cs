Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

if(idade >= 18)
{
    Console.WriteLine("Voto obrigatório!");
} 
else if(idade == 16 || idade == 17)
{
    Console.WriteLine("Voto facultativo!");
}
else
{
    Console.WriteLine("Você não pode votar ainda!");
}


































































































// string = texto, precisa de áspas duplas
// int = inteiro, não precisa de áspas duplas



// Console.WriteLine("Digite seu nome:");
// string nomeUsuario = Console.ReadLine();

// Console.WriteLine("Digite a sua idade:");
// int idade = int.Parse(Console.ReadLine());

// Console.WriteLine("Seja bem vindo " + nomeUsuario + ", você tem " + idade + " anos.");