using System.Reflection.PortableExecutable;

string nome = "Gabriel";
Console.WriteLine($"Nome: {nome}");

string[] nomes = new string[4];
int[] idades = new int[4];
int opcao = -1;
int totalAlunos = 0;

/*nomes[0] = "Maria";
idades[0] = 20;
nomes[1] = "Matheus";
idades[1] = 16;
nomes[2] = "Eloysa";
idades[2] = 17;
nomes[3] = "Felipe";
idades[3] = 17;


Console.WriteLine();
Console.WriteLine();
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes[3]);*/

do
{
    Console.Clear();
    Console.WriteLine($"1) Cadastra Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
    Console.Write($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar ...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarAlunos();
            break;

        case 2:
            ListarAlunos();
            break;


        default:
            Console.WriteLine($"Opção invalida, pressione <Enter> para continuar");
            break;
    }



} while (opcao != 0);




void CadastrarAlunos()
{
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} alunos(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione uma tecla para continuar");
    Console.ReadLine();

    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        return;
    }
}




void ListarAlunos()
{

    Console.WriteLine();
    Console.WriteLine($"Resultado: ");


    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine(nomes[i]);
        Console.WriteLine($" Nome: {nomes[i]}");
        Console.WriteLine($"Idade: {idades[i]} anos");
        Console.WriteLine();
    }
    Console.WriteLine($"");

}

