using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aviao : Veiculo
    {
        public int QtdAssentos;
        public void Decolar()
        {
            Console.WriteLine($"Aviao decolando !!!");
        }

        public void Pousando()
        {
            Console.WriteLine($"Aviao decolando !!!");
        }
    }
}