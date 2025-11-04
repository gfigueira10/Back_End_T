using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pesoa3Sobrecargas
    {
        public string Nome;
        public int Idade;


        public Pesoa3Sobrecargas()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }

        public Pesoa3Sobrecargas(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public Pesoa3Sobrecargas(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
        }

    }
}