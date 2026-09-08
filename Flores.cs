using System.Formats.Asn1;

class Flores
{
    private string? nome;
    private string? cor;
    private string? sonho;
    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string? Cor
    {
        get { return cor; }
        set { cor = value; }
    }
    public string? Sonho
    {
        get { return sonho; }
        set { sonho = value; }
    }

    public Flores(string nome, string cor, string sonho)
    {
        if (nome == null)
        {
            Console.WriteLine("Nome nulo!");
        }

        List<string> cores = new List<string>
        {
            "Dourada",
            "Azul",
            "Amarela",
            "Verde",
            "Roxa",
            "Laranja",
            "Ciana"
        };

        if (!cores.Contains(cor))
        {
            throw new ArgumentException("Cor inválida!");
        }

        if (sonho == null)
        {
            Console.WriteLine("Sonho nulo!");
        }
        else
        {
            this.nome = nome;
            this.cor = cor;
            this.sonho = sonho;         
        }
    }

    public override string ToString()
    {
        return $"Flor: {nome} || Cor: {cor}";
    }

    public void Sonhar()
    {
        Console.WriteLine($"O sonho de {nome} era {sonho}. Obrigada por ver meu sonho!");
    }
}