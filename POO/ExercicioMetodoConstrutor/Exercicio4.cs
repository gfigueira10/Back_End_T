using System;

namespace Banco
{
    public class ContaBancaria
    {
        // Atributos
        public string Titular;
        public double Saldo;

        // Construtor que recebe os valores
        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        // Método para mostrar os dados da conta
        public void MostrarDados()
        {
            Console.WriteLine($"Titular: {Titular} | Saldo: R${Saldo}");
        }
    }
}
