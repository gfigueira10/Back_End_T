using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Ola, eu sou uma pessoa !!");
        }

        public override void Mover()
        {
            Console.WriteLine($"Eu estou andando !!");
        }
    }
}