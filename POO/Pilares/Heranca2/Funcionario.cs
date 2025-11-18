using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Classe Funcionario
public class Funcionario
{
    // Propriedades da classe
    public string Nome { get; set; }
    public double SalarioBase { get; set; }

    public Funcionario(string nome, double salarioBase)
    {
        Nome = nome;
        SalarioBase = salarioBase;
    }

    // Método para calcular o salário (sem bônus)
    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}
