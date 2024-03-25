public class Professor
{
    public string nome;
    public List<Disciplina> disciplinasLecionadas = new List<Disciplina>();
    public void AddDisciplina(Disciplina disciplina)
    {
        disciplinasLecionadas.Add(disciplina);
    }
    public void Ficha()
    {
        System.Console.WriteLine($"Disciplinas lecionadas pelo Professor {nome}:");
        foreach (var disciplina in disciplinasLecionadas)
        {
            System.Console.WriteLine(disciplina.nome);
        }
    }




}// end of class Professor

// Aluno - nome, idade, notas
// Professor - nome,disciplinasLecionadas
// Disciplina - nome,alunosMatriculados
