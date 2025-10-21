int numeroDigitado = 0;
int i = 1;
int n = 1;


Console.WriteLine("Quantos numeros voce deseja digitar ?");
numeroDigitado = int.Parse(Console.ReadLine());

while (n <= numeroDigitado)
{
    Console.WriteLine("Digite um numero");
    i = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        Console.WriteLine($"O numero digitado e par: {i}");
    }
 n++;
}