class Livro
{
    private string? nome;
    private string? autor;
    private int ano;
    private bool disponivel;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }
    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }
    public bool Disponivel
    {
        get { return disponivel; }
        set { disponivel = value; }
    }

    public void Emprestar()
    {
        if (disponivel)
        {
            Console.WriteLine("Livro emprestado com sucesso!");
            disponivel = false;
        }
        else
        {
            Console.WriteLine("Livro não disponível");
        }
    }

    public void Devolver()
    {
        if (disponivel == false)
        {
            Console.WriteLine("Livro devolvido com sucesso!");
            disponivel = true;
        }
        else
        {
            Console.WriteLine("Livro já disponível");
        }
    }

    public Livro(string nome, string autor, int ano, bool disponivel)
    {
        if (nome == null || autor == null)
        {
            Console.WriteLine("Nome e/ou autor nulo(s)");
        }
        else if (ano > 2026)
        {
            Console.WriteLine("Ano inválido");
        }
        else
        {
            this.nome = nome;
            this.autor = autor;
            this.ano = ano;
            this.disponivel = disponivel;
        }
    }

    public override string ToString()
    {
        return $"Nome do livro: {nome} || Autor: {autor} || Ano de lançamento: {ano} || Disponível: {disponivel}";
    }
}