using System;

namespace Retangulo
{
    public class retangulo
    {
        public int Altura;
        public int Largura;


        public retangulo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

         // Construtor altura e largura = 1
    public retangulo()
    {
        Altura = 1;
        Largura = 1;
    }

    // Método para calcular a área
    public int CalcularArea()
    {
        return Altura * Largura;
    }
     

         // Método para mostrar os dados da conta
        public void MostrarDados()
        {
            Console.WriteLine($"Altura: {Altura} | Largura: {Largura}");
        }
    }
}