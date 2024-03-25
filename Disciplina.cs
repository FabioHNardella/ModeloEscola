public class Disciplina
{
    public string nome;
    public List<Aluno> alunosMatriculados = new List<Aluno>();
    public void Matricular(Aluno aluno)
    {
        alunosMatriculados.Add(aluno);
    }// end of function Matricular
    public void AlunosMatriculados()
    {
        foreach (var aluno in alunosMatriculados)
        {
            System.Console.WriteLine($"{aluno.nome} está matriculado(a) em {nome}");
        }
    }// enf of function AlunosMatriculados
}// end of class Disciplina
