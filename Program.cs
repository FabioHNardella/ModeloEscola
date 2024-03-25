// Professores
Professor prof1 = new Professor();
prof1.nome = "Fabio";
Professor prof2 = new Professor();
prof2.nome = "Willian";
// Alunos
Aluno aluno1 = new Aluno();
aluno1.nome = "Sofia";
Aluno aluno2 = new Aluno();
aluno2.nome = "Poloni";
// Disciplinas
Disciplina hist = new Disciplina();
hist.nome = "História";
Disciplina geo = new Disciplina();
geo.nome = "Geografia";
Disciplina ing = new Disciplina();
ing.nome = "Inglês";
Disciplina mat = new Disciplina();
mat.nome = "Matemática";
// Adicionando Disciplinas aos Professores
prof1.AddDisciplina(hist);
prof1.AddDisciplina(mat);
prof2.AddDisciplina(ing);
prof2.AddDisciplina(geo);
// Matriculando Alunos nas Disciplinas
hist.Matricular(aluno1);
mat.Matricular(aluno1);
ing.Matricular(aluno2);
geo.Matricular(aluno2);
// Atribuindo notas aos Alunos
aluno1.AddNota(9);
aluno1.AddNota(7);
aluno2.AddNota(9);
aluno2.AddNota(4);
// Ficha Professores
prof1.Ficha();
prof2.Ficha();
System.Console.WriteLine("\n");
// Exibindo alunos matriculados em cada disciplina
hist.AlunosMatriculados();
mat.AlunosMatriculados();
ing.AlunosMatriculados();
geo.AlunosMatriculados();
System.Console.WriteLine("\n");
// Ficha Alunos
aluno1.Ficha();
aluno2.Ficha();
