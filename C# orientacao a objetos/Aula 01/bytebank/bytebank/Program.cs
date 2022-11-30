using bytebank;

ContaCorrente contaDoTitular = new ContaCorrente();
contaDoTitular.titular = "Guilherme Felipe Henrique Pontes";
contaDoTitular.numero_agencia = 18;
contaDoTitular.conta = "1010-X";
contaDoTitular.saldo = 774.06;

Console.WriteLine("Saldo da conta do " + contaDoTitular.titular + " = " + contaDoTitular.saldo);

contaDoTitular.Depositar(418.41);

Console.WriteLine("Saldo da conta do " + contaDoTitular.titular + " pós depósito = " + contaDoTitular.saldo);

if (contaDoTitular.Sacar(200) == true)
{
    Console.WriteLine("Saldo da conta do " + contaDoTitular.titular + " pós saque = " + contaDoTitular.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar o saque!");
}

Console.WriteLine();

ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da conta: {contaDoTitular.titular}");
Console.WriteLine($"Número da conta: {contaDoTitular.conta}");
Console.WriteLine($"Agência: {contaDoTitular.numero_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoTitular.saldo)}");

Console.ReadKey();
