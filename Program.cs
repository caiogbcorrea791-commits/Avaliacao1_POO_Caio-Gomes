// Classe 1: Retângulo

Retangulo retangulo1 = new Retangulo(10, 5);
Retangulo retangulo2 = new Retangulo(20, 15);
Console.WriteLine(retangulo1);
Console.WriteLine(retangulo2);
Console.WriteLine();
retangulo1.CalcularArea();
retangulo2.CalcularArea();

// Espaçamento de classes
Console.WriteLine();
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();
// Classe 2: Aluno

Aluno aluno1 = new Aluno("Caio Gomes", 1);
Aluno aluno2 = new Aluno("Davi Péres", 8);
Aluno aluno3 = new Aluno("Vinicios Alves", 5);
Console.WriteLine(aluno1);
Console.WriteLine(aluno2);
Console.WriteLine(aluno3);
Console.WriteLine();
aluno1.ObterSituacao();
aluno2.ObterSituacao();
aluno3.ObterSituacao();

// Espaçamento de classes
Console.WriteLine();
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();
// Classe 3: Livro

Livro livro1 = new Livro("O Gênio do Crime", "João Carlos Marinho", 1969, true);
Livro livro2 = new Livro("One Piece vol. 1", "Eiichiro Oda", 1997, true);
Console.WriteLine(livro1);
Console.WriteLine();
Console.WriteLine(livro2);
Console.WriteLine();
livro1.Emprestar();
livro1.Emprestar();
Console.WriteLine(livro1);
livro1.Devolver();
Console.WriteLine(livro1);
Console.WriteLine();
livro2.Emprestar();
Console.WriteLine(livro2);
livro2.Devolver();
Console.WriteLine(livro2);