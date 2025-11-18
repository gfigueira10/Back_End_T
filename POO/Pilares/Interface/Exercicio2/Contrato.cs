
namespace ExercicioInterface2
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";


        public Contrato(string contratante, string contratado, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratado;
            TextoClausulas = txtClausulas;
        }


        public void Imprimir()
        {
            Console.WriteLine(@$"
            Partes:
                Contratante: {Contratante}
                Contratado: {PrestadorServico}
                Clausulas do Contrato: 

                {TextoClausulas}
            ");
        }
    }
}