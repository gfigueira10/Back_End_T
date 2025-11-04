using MetodoConstrutor;

//Pessoa fontes = new Pessoa("João", 17);

// fontes.Nome = "Lorenzo";
// fontes.Idade = 20;

// System.Console.WriteLine(@$"O objeto pessoa que eu criei é o {fontes.Nome} com a idade:
// {fontes.Idade}");

// //fontes.Nome = "Gustavo Oliveira";
// fontes.ExibirDados();

// System.Console.WriteLine($"{fontes.Nome}");

Pesoa3Sobrecargas PrimeiraPessoa = new Pesoa3Sobrecargas();

System.Console.WriteLine(@$"Primeira Pessoa Cadastrada
                                            Nome: {PrimeiraPessoa.Nome}        
                                            Idade: {PrimeiraPessoa.Idade}
");

Pesoa3Sobrecargas SegundaPessoa = new Pesoa3Sobrecargas("Matheus Felix");

System.Console.WriteLine(@$"Segunda Pessoa Cadastrada
                                            Nome: {SegundaPessoa.Nome}        
                                            Idade: {SegundaPessoa.Idade}
");



Pesoa3Sobrecargas TerceiraPessoa = new Pesoa3Sobrecargas("Felipe Silva", 16);

Console.WriteLine($"Digite o nome da terceira pessoa: ");
Console.ReadLine();

Console.WriteLine($"Digite a idade da terceira pessoa: ");
int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Terceira Pessoa Cadastrada
                                            Nome: {TerceiraPessoa.Nome}        
                                            Idade: {TerceiraPessoa.Idade}
");


