int opcao = -1;
int totalClientes = 0;
string[] nome = new string[4];
double[] saldos = new double[4];
int totalSaldos = 0;

do
{
    Console.Clear();
    Console.WriteLine($"========= SISTEMA BANCARIO SIMPLES ==========");
    Console.WriteLine();

    Console.WriteLine($"1- Cadastrar Cliente");
    Console.WriteLine($"2- Depositar");
    Console.WriteLine($"3- Sacar");
    Console.WriteLine($"4- Transferir");
    Console.WriteLine($"5- Listar Cliente");
    Console.WriteLine($"0- Sair");

    Console.Write($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar ...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarCliente();
            Console.WriteLine();
            break;


        case 2:
            Depositar();

            
            break;


        case 3:
            Sacar();
            Console.WriteLine();
            break;


        case 4:
            Transferir();
            Console.WriteLine();
            break;


        case 5:
            ListarCliente();
            break;


        default:
            Console.WriteLine($"Opção invalida, pressione <Enter> para continuar");
            break;
    }

Console.WriteLine($"Clique em <Enter> para continuar");
    Console.ReadLine();


} while (opcao != 0);





void CadastrarCliente()
{
    if (totalClientes >= 3)
    {
        Console.WriteLine($"Limite de Ocupação atingido");
        return;
    }

    Console.WriteLine($"Digite o nome do cliente");
    string n = Console.ReadLine();
    nome[totalClientes] = n;
    saldos[totalClientes] = 0;
    totalClientes++;

}



int BuscarCliente()
{
    ListarCliente();
    Console.WriteLine($"Digite o numero do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return idCliente;
}




void Depositar()
{
    if (totalSaldos >= 4)
    {
        Console.WriteLine($"Limite de Ocupação atingido");
        return;
    }

    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Digite quanto deseja depositar? ");
    double s = double.Parse(Console.ReadLine());

    saldos[idCliente] += s;

    Console.WriteLine($"Deosito de R$ {s} realizado !!!");
}





void Sacar()
{
    if (totalSaldos >= 4)
    {
        Console.WriteLine($"Limite de Ocupação atingido");
        return;
    }

    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Digite quanto deseja sacar? ");
    double valor = double.Parse(Console.ReadLine());

    if (saldos [idCliente] >= valor )
    {
        saldos[idCliente] -= valor;
        Console.WriteLine($"Saque Realizado com sucesso !!!");
    } else
    {
        Console.WriteLine($"Saldo insuficiente");
    }


}




void Transferir()
{
    Console.WriteLine($"==   TRANSFERENCIA ==");

    Console.WriteLine($"Conta de Origem");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }

    Console.WriteLine($"Conta de Destino");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.WriteLine($"Valor para transferir: ");
    double valorTransferencia = double.Parse(Console.ReadLine());


    if (saldos[idClienteOrigem] >= valorTransferencia)
    {
        saldos[idClienteOrigem] -= valorTransferencia;
        saldos[idClienteDestino] += valorTransferencia;
        Console.WriteLine($"Transferencia Realizada !!!");
    } else
    {
        Console.WriteLine($"Saldo insuficiente !!! ");
    }

}




void ListarCliente()
{

    Console.WriteLine();
    Console.WriteLine($"======= LISTA DE CLIENTES =======");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"Nome: {nome[i]} | saldo: R$ {saldos[i]}");
        Console.WriteLine();
    }
}
