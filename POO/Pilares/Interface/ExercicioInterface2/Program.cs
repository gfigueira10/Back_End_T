//Retangulo

using Exemplos;

Console.WriteLine($"========= Bem vindo ao programa Calculos de Geometria");
Console.WriteLine();

Console.WriteLine($"Vamos calcular o Retangulo");

// Altura e Largura

Console.Write($"Digite a largura do Retangulo: ");
float l = float.Parse(Console.ReadLine());
Console.Write($"Digite a altura do Retangulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();

retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();


Console.WriteLine();
Console.WriteLine($"Agora vamos calcular o Circulo");

// Altura e Largura

Console.Write($"Digite o raio do Circulo: ");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Fim do Programa !!!");
Console.WriteLine();