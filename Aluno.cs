class Aluno
{
    private string? nome;
    private double nota;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public double Nota
    {
        get { return nota; }
        set { nota = value; }
    }

    public Aluno(string nome, double nota)
    {
        if (nome == null)
        {
            Console.WriteLine("Nome não pode ser nulo");
        }
        else if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida");
        }
        else
        {
            this.nome = nome;
            this.nota = nota;
        }
    }

    public override string ToString()
    {
        return $"Nome do aluno: {this.nome} || Nota do aluno: {this.nota}";
    }

    public void ObterSituacao()
    {
        if (nota >= 7)
        {
            Console.WriteLine("Aluno está aprovado");
        }
        else if (nota < 7 && nota >= 5)
        {
            Console.WriteLine("Aluno está de recuperação");
        }
        else
        {
            Console.WriteLine("Aluno está reprovado");
        }
    }
}