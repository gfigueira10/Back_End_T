using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Hello
    {
        
            // Propriedades/ Caracteristicas - variaveis internas dessa classe
            public string TextoHello = "";


        // Metodos/ Comportamentos/ Acoes - Sao as funcoes internas dessa classe
        public void SaudarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }


        public void SaudarComNome(string n)
        {
            Console.WriteLine($"Ola {n}");
        }
        
    }
}