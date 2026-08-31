class Retangulo
{
    private double baseR;
    private double alturaR;
    public double BaseR
    {
        get { return baseR; }
        set { BaseR = value; }
    }
    public double AlturaR
    {
        get { return alturaR; }
        set { baseR = value; }
    }
    public Retangulo(double baseR, double alturaR)
    {   
        if (baseR <= 0 || alturaR <= 0)
        {
            Console.WriteLine("Base e/ou altura inválida(s)");
        }
        else if (alturaR == baseR)
        {
            Console.WriteLine("Altura não pode ser igual a base");
        }
        else
        {
            this.baseR = baseR;
            this.alturaR = alturaR;           
        }
    }

    public override string ToString()
    {
        return $"Base do Retângulo: {this.baseR} || Altura do Retângulo: {this.alturaR}";
    }

    public void CalcularArea()
    {
        Console.Write("A área do Retângulo é: ");
        Console.WriteLine(baseR * alturaR);
    }
}