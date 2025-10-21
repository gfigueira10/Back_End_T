int operações = -1;
double numero1, numero2;

do
{
    Console.Clear();
    Console.WriteLine("===== CALCULADORA =====");
    Console.WriteLine();
    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("Escolha uma das operações acima: ");
    operações = int.Parse(Console.ReadLine());


    Console.WriteLine($"Digite o primeiro numero: ");
    numero1 = double.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o segundo numero: ");
    numero2 = double.Parse(Console.ReadLine());

    switch (operações)
    {
        case 1:
            double resultado = Somar(numero1, numero2);
            Console.WriteLine($"Resultado da Soma: {resultado}");
            break;

        case 2:
            resultado = Subtrair(numero1, numero2);
            Console.WriteLine($"Resultado da Subtração: {resultado}");
            break;

        case 3:
            resultado = Multiplicar(numero1, numero2);
            Console.WriteLine($"Resultado da Multiplicação: {resultado}");
            break;

        case 4:
            if (numero2 == 0)
            {
                Console.WriteLine($"Divisão por zero");
            }

            else
            {
                resultado = Dividir(numero1, numero2);
                Console.WriteLine($"Resultado da Divisão: {resultado}");
            }
            break;


        default:
            Console.WriteLine($"Obrigado por utilizar nosso programa !!");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla + <Enter> para continuar");
    Console.ReadLine();

} while (operações != 0);



double Somar(double x, double y)
{
    return x + y;
}
double Subtrair(double x, double y)
{
    return x - y;
}
double Multiplicar(double x, double y)
{
    return x * y;
}
double Dividir(double x, double y)
{
    return x / y;
}