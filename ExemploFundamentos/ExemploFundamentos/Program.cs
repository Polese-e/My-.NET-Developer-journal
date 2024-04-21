using System.Reflection.Metadata;
using ExemploFundamentos.Common.Models;
// DateTime dataAtual = DateTime.Now.AddMonths(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH/mm" ));

// string apresentacao = "Olá Enzo";

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Enzo";
// pessoa1.Idade = 19;
// pessoa1.Apresentar();

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

// bool maiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada liberada!");
// }

// ================================================================================================================== //

// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }

// ================================================================================================================== //

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

// ================================================================================================================== //

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 40);
// calc.Multiplicar(10, 20);
// calc.Dividir(10, 5);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// ================================================================================================================== //

// int numeroIncremento = 10;

// Console.WriteLine("Incrementendo o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;

// Console.WriteLine("Decrementendo o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

// ================================================================================================================== //

// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }

// ================================================================================================================== //

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador} Execução: {numero} X {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

// ================================================================================================================== //

// int numero = 0, soma = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
    
//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"O total da soma foi {soma}");

// ================================================================================================================== //

// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("digite sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente: ");
//     Console.WriteLine("2 - Buscar cliente: ");
//     Console.WriteLine("3 - Apagar cliente: ");
//     Console.WriteLine("4 - Encerrar: ");

//     string opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro de cliente");
//         break;

//         case "2":
//         Console.WriteLine("Busca de cliente");
//         break;
        
//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;
        
//         case "4":
//         exibirMenu = false;
//         // Console.WriteLine("Encerrar");
//         // Environment.Exit(0);
//         break;
        
//         default:
//         Console.WriteLine("Opção inválida");
//         break;
//     }
// }

// Console.WriteLine("O programa foi encerrado");

