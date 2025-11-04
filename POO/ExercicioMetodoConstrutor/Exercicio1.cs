using System;

class Carro
{
    // atributos
    public string Marca;
    public string Modelo;
    public int Ano;

    // Metodo construtor
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;

        // Exibe os dados do carro
        Console.WriteLine("Dados do carro:");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Ano: {ano}");
    }

    
}