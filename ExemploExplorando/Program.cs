using ExemploExplorando.Models;
using System.Globalization;

// Pessoa p1 = new Pessoa(nome: "Enzo", sobrenome: "Polese");
// Pessoa p2 = new Pessoa(nome: "Alícya", sobrenome: "Capucho");
// Pessoa p3 = new Pessoa(nome: "Raphael", sobrenome: "Simões");

// Curso cursoIngles = new Curso();
// cursoIngles.Nome = "Ingles";
// cursoIngles.Alunos = new List<Pessoa>();

// cursoIngles.AdicionarAluno(p1);
// cursoIngles.AdicionarAluno(p2);
// cursoIngles.AdicionarAluno(p3);
// cursoIngles.ListarAlunos();
// cursoIngles.ObterQuantidadeDeAlunosMatriculados();

/* ================================================================================================================== */

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("C1"));
// Console.WriteLine(valorMonetario.ToString("C3"));
// Console.WriteLine(valorMonetario.ToString("N3"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

/* ================================================================================================================== */

// string dataString = "23/04/2024 09:00";

// DateTime.TryestadoseExact(dataString, )

// DateTime data = DateTime.estadose(dataString);

// Console.WriteLine(data.ToString("dd/MM/yy HH/mm"));
// Console.WriteLine(data);
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

/* ================================================================================================================== */

// try
// {
// string[] linhas = File.ReadAllLines("Arquivos/pastaInexistente/arquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// } 
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Error: File not found: {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Error: Directory not found: {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }

/* ================================================================================================================== */

// new ExemploExcecao().Metodo1();

/* ================================================================================================================== */

// // Criando uma fila de inteiros
// Queue<int> fila = new Queue<int>();

// // Adicionando elementos à fila
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// // Imprimindo os elementos da fila (primeiro para o último)
// Console.WriteLine("Elementos da fila (primeiro para o último):");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// // Removendo o elemento do início da fila e armazenando-o em uma variável
// int itemRemovido = fila.Dequeue(); // Remove o elemento 2 da fila e o armazena na variável itemRemovido

// // Informando o elemento removido
// Console.WriteLine($"\nRemovendo o item: {itemRemovido}");

// // Adicionando outro elemento à fila
// fila.Enqueue(10);

// // Imprimindo os elementos da fila após a remoção e adição (primeiro para o último)
// Console.WriteLine("\nElementos da fila após remoção e adição (primeiro para o último):");
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

/* ================================================================================================================== */

// // Criando uma pilha de inteiros
// Stack<int> pilha = new Stack<int>();

// // Adicionando elementos à pilha
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10); 

// // Imprimindo os elementos da pilha (do topo para a base)
// Console.WriteLine("Elementos da pilha (topo para base):");
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// // Removendo o elemento do topo da pilha e armazenando-o em uma variável
// int itemRemovido1 = pilha.Pop(); // Remove o elemento 10 da pilha e o armazena na variável itemRemovido

// // Informando o elemento removido
// Console.WriteLine($"\nRemovendo o item do topo: {itemRemovido}");

// // Adicionando outro elemento à pilha
// pilha.Push(12); 

// // Imprimindo os elementos da pilha após a remoção e adição (do topo para a base)
// Console.WriteLine("\nElementos da pilha após remoção e adição (topo para base):");
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

/* ================================================================================================================== */

// // Criando um dicionário
// Dictionary<string, string> estados = new Dictionary<string, string>()
// {
//     {"SP", "São Paulo"},
//     {"BA", "Bahia"},
// };

// // Adicionando elementos ao dicionário
// estados.Add("RJ", "Rio de Janeiro");

// // Imprimindo os elementos do dicionário
// foreach (var estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
// }

// // Removendo um elemento do dicionário
// estados.Remove("BA");

// // Alterando o valor de um elemento do dicionário
// estados["SP"] = "São Paulo - Capital";

// Console.WriteLine("==============================================");
// // Imprimindo os elementos do dicionário após as alterações
// foreach (var estado in estados)
// {
//     Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
// }

// // Verificando se uma chave existe no dicionário
// string chave = "BA";
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {estados[chave]}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

/* ================================================================================================================== */

(int, string, string, decimal) tupla = (1, "Enzo", "Polese", 1.67M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

/* ================================================================================================================== */

(int idCliente, string nomeCliente, string sobrenomeCliente, string emailCliente) cliente = (1, "Enzo", "Polese", "enzo.polese@example.com");

Console.WriteLine($"Id do cliente: {cliente.idCliente}");
Console.WriteLine($"Nome do cliente: {cliente.nomeCliente}");
Console.WriteLine($"Sobrenome do cliente: {cliente.sobrenomeCliente}");
Console.WriteLine($"Email do cliente: {cliente.emailCliente}");

/* ================================================================================================================== */

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    // Console.WriteLine("Quantidade de linhas do arquivo:" + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}