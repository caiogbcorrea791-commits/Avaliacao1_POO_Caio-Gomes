class Lampada
{
    private string? cor;
    private bool estado;
    public string? Cor
    {
        get { return cor; }
        set { cor = value; }
    }
    public bool Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public Lampada(string cor, bool estado)
    {
        List<string> cores = new List<string>
        {
            "Branca",
            "Amarela",
            "Laranja"
        };

        if (!cores.Contains(cor))
        {
            throw new ArgumentException("Cor inválida!");
        }
        else
        {
            this.cor = cor;
            this.estado = estado;
        }
    }

    public override string ToString()
    {
        return $"Cor da lâmpada: {cor} || Está ligada?: {(estado ? "Sim" : "Não")}";
    }

    public void Desligar()
    {
        if (estado)
        {
            estado = false;
            Console.WriteLine("Lâmpada desligada");
        }
        else
        {
            Console.WriteLine("Lâmpada já está desligada");
        }
    }

        public void Ligar()
    {
        if (estado == false)
        {
            estado = true;
            Console.WriteLine("Lâmpada ligada");
        }
        else
        {
            Console.WriteLine("Lâmpada já está ligada");
        }
    }
}