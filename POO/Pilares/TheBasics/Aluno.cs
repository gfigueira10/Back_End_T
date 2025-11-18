using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aluno : Pessoa
    {
        // Cria um construtor na classe Aluno que recebe o endereco
        // Chama o construtor da classe mae (base) e repassa para o endereco dela
        public Aluno(Endereco endereco) : base(endereco)
        {
        }


        public string RA;
        public float NotaFinal;
        public string Curso;
    }
}