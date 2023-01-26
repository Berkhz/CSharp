using Aulas.Models;

ContaCorrente cc = new ContaCorrente(50);
cc.Numero = 1234;
cc.ExibirSaldo();

cc.Sacar(10);

cc.ExibirSaldo();

// Exemplo Aula 2
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Kauan";
// pessoa1.Idade = 19;
// pessoa1.Apresentar();