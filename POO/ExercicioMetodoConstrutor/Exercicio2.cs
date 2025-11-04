using System;

namespace Escola
{
    public class Aluno
    {
        // Atributos
        public string Nome;
        public int Nota;

        // Construtor sem parâmetros 
        public Aluno()
        {
            Nome = "Sem nome";
            Nota = 0;
        }

        // Construtor com parâmetros
        public Aluno(string nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }

        // Exibir
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} | Nota: {Nota}");
        }
    }
}