using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;

        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {
            NivelVolume++;
            Console.WriteLine($"Nivel atual do volume: {NivelVolume}"); 
            }else
            {
                Console.WriteLine($"O volume ja atingiu o nivel maximo {NivelVolume}");
            }
            
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a tv !!");
        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
            Console.WriteLine($"o Volume ja esta no minimo: {NivelVolume}"); 

            }else
            {
                NivelVolume--;
                Console.WriteLine($"Volume atual: {NivelVolume}");
            }
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando a tv !!");
        }
    }
}