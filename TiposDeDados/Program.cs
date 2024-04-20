using System.Reflection.Metadata;
using ExemploFundamentos.Models;

// DateTime dataAtual = DateTime.Now.AddMonths(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH/mm" ));

// string apresentacao = "Olá Enzo";

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Enzo";
// pessoa1.Idade = 19;
// pessoa1.Apresentar();

// Console.WriteLine(apresentacao);

// ================================================================================================================== //

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// ================================================================================================================== //

// int a = 5;
// double b = a;

// Console.WriteLine(b);

// int c  = 5;
// long d =  c;

// Console.WriteLine(d);

// int e = int.MaxValue;
// long f = e;

// Console.WriteLine(f);

// ================================================================================================================== //

// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);

// ================================================================================================================== //

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }

// ================================================================================================================== //

// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("É uma vogal.");
//     break;
    
//     default:
//     Console.WriteLine("Não é uma vogal.");
//     break;
// }

// ================================================================================================================== //

bool maiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada liberada!");
}

// ================================================================================================================== //

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

// ================================================================================================================== //

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia");
}