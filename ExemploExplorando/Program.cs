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

// DateTime.TryParseExact(dataString, )

// DateTime data = DateTime.Parse(dataString);

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

new ExemploExcecao().Metodo1();