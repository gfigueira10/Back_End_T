
namespace ExercicioInterface2
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        public float Juros = 0.10f;


        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }


        public void Imprimir()
        {

            Console.WriteLine(@$"
            
                Credor: {Credor}
                Devedor: {Devedor}
                Dias de Atraso: {DiasDeAtraso} dia(s)
                Valor: R${Valor:F2}
                Juros: R${(Juros * DiasDeAtraso):F2}
                Total com Juros: R${Valor:F2}
            ");

            Console.WriteLine($"Credor: {Credor}");
            Console.WriteLine($"Devedor: {Devedor}");
            Console.WriteLine($"Dias de Atraso: {DiasDeAtraso}");
        }

        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if (DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Divida encaminhada para o SERASA !!");
            }
        }
    }
}