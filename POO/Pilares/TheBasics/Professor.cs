using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Professor : Pessoa
    {
        public string Salario;

        // Chama o construtor da classe mae e repassa o endereco pra la
        public Professor(Endereco endereco) : base(endereco)
        {
            
        }
    }
}