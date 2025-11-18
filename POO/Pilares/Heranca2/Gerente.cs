using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Gerente : Funcionario
{
    // Bônus
    public double Bonus { get; set; }

    public Gerente(string nome, double salarioBase, double bonus)
        : base(nome, salarioBase)
    {
        Bonus = bonus;
    }

    // Sobrescreve o método CalcularSalario
    public override double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}
