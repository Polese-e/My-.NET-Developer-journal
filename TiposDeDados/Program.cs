using ExemploFundamentos.Models;

DateTime dataAtual = DateTime.Now.AddMonths(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH/mm" ));

string apresentacao = "Olá Enzo";

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Enzo";
pessoa1.Idade = 19;
pessoa1.Apresentar();

Console.WriteLine(apresentacao);