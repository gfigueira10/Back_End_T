
using ExercicioInterface2;
List<IImprimivel> documentos = new List<IImprimivel>();
// Fatura fatEdu = new Fatura("Eduardo","Izabel Dark Lab", 50, 1);

// fatEdu.Imprimir();

int opcao;

do
{
    Console.WriteLine($"Menu de Opcoes");
    Console.WriteLine(@$"
1) Cadastrar Faturas
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatorios
6) Listar Contatos
0) Sair
Escolha a opcao:
");

    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine();


    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatorio");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            break;
        case 4:
            Console.WriteLine($"Listar Faturas");
            break;
        case 5:
            Console.WriteLine($"Listar Relatorios");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opcao Invalida");
            break;

    }

} while (opcao != 0);



// Funcoes Auxiliares
void CadastrarFatura()
{
    Console.Write($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();

    Console.Write($"Digite o nome do credor: ");
    string cred = Console.ReadLine();

    Console.Write($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());

    Console.Write($"Quantos dias a fatura esta em atraso? ");
    int diasAtraso = int.Parse(Console.ReadLine());


    // cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    // cadastra a futura na lista
    documentos.Add(f);
}


void CadastrarContrato()
{
    Console.Write($"Digite o nome do contratante: ");
    string contratante = Console.ReadLine();
    Console.Write($"Digite o nome da Empresa Contratada: ");
    string contratado = Console.ReadLine();

    Console.Write($"Digite as Clausulas do Contrato: ");
    string txtClausulas = Console.ReadLine();

    Contrato ojbContrato = new Contrato(contratante, contratado, txtClausulas);
    documentos.Add(ojbContrato);
}



void CadastrarRelatorio()
{
    Console.Write($"Digite o nome do responsavel do relatorio: ");
    string resp = Console.ReadLine();

    Console.Write($"Digite o texto do relatorio: ");
    string txt = Console.ReadLine();

    Relatorio relatorio = new Relatorio(resp, txt);
    documentos.Add(relatorio);

    Console.WriteLine($"Relatorio cadastrado com sucesso");
}



void ListarFaturas()
{
    Console.WriteLine($"Listando as Faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}


void ListarContratos()
{
    Console.WriteLine($"Listando os Contratos: ");
    foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}


void ListarRelatorios()
{
    Console.WriteLine($"Listando os Relatorios: ");
    foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}