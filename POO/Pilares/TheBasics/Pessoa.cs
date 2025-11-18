using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// namespace pode ser considerado como a pasta do projeto
// namespace e o modulo do sistema
// namespace e como um pacote, 
namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Endereco EnderecoCompleto;


        public Pessoa (Endereco endereco)
        {
            EnderecoCompleto = endereco;
        }



        public void Falar()
        {
            Console.WriteLine($"Ola, eu sou o {Nome} e tenho {Idade} anos");
        }

        public void Envelhecer()
        {
            Idade++;
        }
    }
}