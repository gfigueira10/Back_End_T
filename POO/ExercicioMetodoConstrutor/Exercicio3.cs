using System;

namespace Loja
{
    public class Produtos
    {
        // Atributos
        public string Nome;
        public int Preco;
        public int Estoque;

        // Construtor que recebe os valores
        public Produtos(string nome, int preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        // Método para mostrar os dados do produto
        public void MostrarDados()
        {
            Console.WriteLine($"Produto: {Nome} | Preço: R${Preco:F2} | Estoque: {Estoque} unidades");
        }
    }
}
