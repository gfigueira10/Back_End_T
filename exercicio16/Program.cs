string cargo;
double salario, salario2 = 0;


Console.WriteLine("Escolha um dos cargos:");
Console.WriteLine();
Console.WriteLine("Produção");
Console.WriteLine("Administrativo");
Console.WriteLine("Diretoria");
cargo = Console.ReadLine();
Console.WriteLine("Digite o seu salario:");
salario = double.Parse(Console.ReadLine());

if (cargo == "Produção")
{
    salario2 = salario + 1.065;
}
else if (cargo == "Administrativo")
{
    salario2 = salario + 1.075;
}
else if (cargo == "Diretoria")
{
    salario2 = salario + 1.12;
}
else
{
    salario2 = salario;
    Console.WriteLine("Cargo invalido, sem direito a reajuste");
}
Console.WriteLine($"Seu novo salario e : {salario2}");