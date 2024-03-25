public class Aluno
{
    public string nome;
    public int idade;
    public List<int> notas = new List<int>();

    public void AddNota(int nota)
    {
        notas.Add(nota);
    }
    public void Ficha()
    {
        System.Console.WriteLine($"Ficha {nome}:");
        System.Console.WriteLine($"Idade: {idade}");
        System.Console.WriteLine($"Notas:");
        foreach (int nota in notas)
        {
            System.Console.WriteLine(nota);
        }
    }

}// end if class Aluno
