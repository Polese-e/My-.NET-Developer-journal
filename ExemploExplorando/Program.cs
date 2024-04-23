using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Enzo", sobrenome: "Polese");
Pessoa p2 = new Pessoa(nome: "Alícya", sobrenome: "Capucho");
Pessoa p3 = new Pessoa(nome: "Raphael", sobrenome: "Simões");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Ingles";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.AdicionarAluno(p3);
cursoIngles.ListarAlunos();
cursoIngles.ObterQuantidadeDeAlunosMatriculados();