using ExemploPOO.Interfaces;
using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Enzo";
// p1.Idade = 19;

// p1.Apresentar();

/* ================================================================================================================== */

// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();

/* ================================================================================================================== */

// Aluno a1 = new Aluno();

// a1.Nome = "Enzo";
// a1.Idade = 19;
// a1.Email = "enzo.polese@exemplo.com";
// a1.Nota = 10;

// a1.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Eduardo";
// p1.Idade = 30;
// p1.Salario = 1000;
// p1.Apresentar();

/* ================================================================================================================== */

// Corrente c = new Corrente();

// c.Creditar(500);
// c.ExbirSaldo();

/* ================================================================================================================== */

// Pessoa pessoa = new Pessoa("Enzo");
// Aluno aluno = new Aluno("Eduardo");
// Professor professor =  new Professor();

// professor.Nome = "Jonas";

// pessoa.Apresentar();
// aluno.Apresentar();
// professor.Apresentar();

/* ================================================================================================================== */

// Computador c1 = new Computador();

// Console.WriteLine(c1.ToString());

/* ================================================================================================================== */

ICalculadora calc = new Calculadora();

Console.WriteLine(calc.Multiplicar(9, 3));