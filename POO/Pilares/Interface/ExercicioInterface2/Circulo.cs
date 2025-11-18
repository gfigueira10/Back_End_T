using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Circulo : IForma
    {
        public float PI = 3.14f;
        public float raio;

        public void CalcularArea()
        {
            Console.WriteLine($"A area do circulo e: {PI * raio * raio}");
        }
    }
}