using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoTitular = new ContaCorrente();
//contaDoTitular.titular = "Kauan Henrique Bertalha";
//contaDoTitular.numero_agencia = 01;
//contaDoTitular.conta = "1010-1";
//contaDoTitular.saldo = 774.06;

//Console.WriteLine("Saldo da conta do(a) " + contaDoTitular.titular + " = " + contaDoTitular.saldo);

//contaDoTitular.Depositar(418.41);

//Console.WriteLine("Saldo da conta do(a) " + contaDoTitular.titular + " pós depósito = " + contaDoTitular.saldo);

//if (contaDoTitular.Sacar(200) == true)
//{
//    Console.WriteLine("Saldo da conta do(a) " + contaDoTitular.titular + " pós saque = " + contaDoTitular.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para realizar o saque!");
//}

//Console.WriteLine();

//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {contaDoTitular.titular}");
//Console.WriteLine($"Número da conta: {contaDoTitular.conta}");
//Console.WriteLine($"Agência: {contaDoTitular.numero_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoTitular.saldo)}");

//ContaCorrente contaDaMarilsa = new ContaCorrente();
//contaDaMarilsa.titular = "Marilsa de Miranda Costa";
//contaDaMarilsa.numero_agencia = 17;
//contaDaMarilsa.conta = "1010-5";
//contaDaMarilsa.saldo = 1000;

//Console.WriteLine();

//Console.WriteLine("Saldo da conta do(a) " + contaDaMarilsa.titular + " = " + contaDaMarilsa.saldo);

//contaDoTitular.Transferir(100, contaDaMarilsa);

//Console.WriteLine("Saldo da conta do(a) " + contaDaMarilsa.titular + " pós transferência = " + contaDaMarilsa.saldo);

//Console.WriteLine();

//Console.WriteLine($"Titular da conta: {contaDaMarilsa.titular}");
//Console.WriteLine($"Número da conta: {contaDaMarilsa.conta}");
//Console.WriteLine($"Agência: {contaDaMarilsa.numero_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDaMarilsa.saldo)}");

//ContaCorrente contaDoSidinei = new ContaCorrente();
//Console.WriteLine(contaDoSidinei.titular);
//Console.WriteLine(contaDoSidinei.saldo);
//Console.WriteLine(contaDoSidinei.numero_agencia);
//Console.WriteLine(contaDoSidinei.conta);

//Cliente cliente = new Cliente(); // Object
//cliente.nome = "Kauan Henrique Bertalha";
//cliente.cpf = "13302153970";
//cliente.profissao = "Auxiliar Administrativo";

//ContaCorrente conta = new ContaCorrente(); // Object
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 1;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome); 
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("N° Conta = " + conta.conta);
//Console.WriteLine("Saldo = R$" + conta.saldo);
//Console.WriteLine("N° Agência = " + conta.numero_agencia);

//Console.WriteLine();
        
//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Marilsa de Miranda Costa";
//conta2.titular.profissao = "Empresária";
//conta2.titular.cpf = "04235656996";
//conta2.contaS = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
conta4.SetSaldo(500);
conta4.Titular = new Cliente();
Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_agencia);

Console.ReadKey();