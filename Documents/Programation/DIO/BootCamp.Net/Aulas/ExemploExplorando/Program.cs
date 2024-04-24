using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Jorge","Silva");

Pessoa p2 = new Pessoa("Fernanda","Queiroz");

Curso asam = new Curso();
asam.Nome = "Empregabilidade";
asam.Alunos = new List<Pessoa>();

asam.AdicionarAluno(p1);
asam.AdicionarAluno(p2);
asam.Listar();

