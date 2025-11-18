
namespace ExercicioInterface2
{
    public class Relatorio : IImprimivel
    {
        public string Nome;
        public string textoRelatorio = "";
        
public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            textoRelatorio = txtRelatorio;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Responsavel: {Nome}");
            Console.WriteLine(textoRelatorio);
            Console.WriteLine($"--");
        }
    }
}