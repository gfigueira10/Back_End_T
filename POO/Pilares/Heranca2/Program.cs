// EXERCICIO - 1

// Cachorro meuCachorro = new Cachorro();
// Gato meuGato = new Gato();

// meuGato.FazerSom();
// meuCachorro.FazerSom();



using Heranca2;


class Program
{
    static void Main()
    {
        // Funcionario
        Funcionario func = new Funcionario("Walyson", 2000);

        // Gerente
        Gerente gerente = new Gerente("Gabriel", 3000, 1000);

        Console.WriteLine("Funcionário: " + func.Nome + " - Salário: R$ " + func.CalcularSalario());
        Console.WriteLine("Gerente: " + gerente.Nome + " - Salário: R$ " + gerente.CalcularSalario());
    }
}
