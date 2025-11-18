
namespace Exemplos
{
    public class Retangulo : IForma
    {
        public float Altura;
        public float Largura;
        
        public void CalcularArea()
        {
           Console.WriteLine($"A area do retangulo e: {Altura * Largura}");
        }
    }
}