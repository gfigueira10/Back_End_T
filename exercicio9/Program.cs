int opcao;

do
{

    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("        Bem Vindo, Usuário");
    Console.WriteLine("-------------------------------------------------------\n");

    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine(" 1");
    Console.WriteLine(" 2");
    Console.WriteLine(" 3");
    Console.WriteLine(" 0 - Sair");

    Console.Write("Digite sua opção: ");
    opcao = int.Parse(Console.ReadLine());

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Numero invalido");
        continue;
    }


    switch (opcao)
    {
        case 1:

            Opcao1();
            break;
        case 2:

            Opcao2();
            break;
        case 3:
            Opcao3();
            break;
        case 0:
            Sair();
            break;
        default:
            OpcaoInvalida();
            break;
    }
} while (opcao != 0);

void Opcao1()
{
    Console.WriteLine("Você escolheu a Opção 1.");
}

void Opcao2()
{
    Console.WriteLine("Você escolheu a Opção 2.");
}
void Opcao3()
{
   Console.WriteLine("Você escolheu a Opção 3.");
}

void Sair()
{
    Console.WriteLine("Saindo do programa...");
}

void OpcaoInvalida()
{
    Console.WriteLine("Opção inválida!");
}