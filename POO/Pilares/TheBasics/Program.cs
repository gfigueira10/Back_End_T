using TheBasics;

Console.Clear();
// string[] nomes = new string[5];
// int[] idades = new int[5];
// string[] logradouro = new string[5];
// List<Pessoa> peoples = new List<Pessoa>();

// Endereco enderecoGabriel = new Endereco();
// enderecoGabriel.Logradouro = "Rua Yaya";

// Pessoa gabriel = new Pessoa(enderecoGabriel);
// gabriel.Nome = "Gabriel Figueira";
// gabriel.Idade = 17;



// Endereco enderecoGustavo = new Endereco();
// enderecoGustavo.Logradouro = "Rua Mercedes Salano";

// Pessoa gustavo = new Pessoa(enderecoGustavo);
// gustavo.Nome = "Gustavo Augusto";
// gustavo.Idade = 17;




// Console.Clear();
// // Pessoa gabriel = new Pessoa();
// // Pessoa gustavo = new Pessoa();
// // Pessoa walyson = new Pessoa();
// // Pessoa davi = new Pessoa();

// // gabriel.Nome = "Gabriel Figueira";
// // gabriel.Idade = 17;
// // gabriel.Logradouro = "Rua Yaya";
// // gabriel.Numero = 206;
// // gabriel.Logradouro = "Apto 134 - Bloco - Bromelia";


// // gustavo.Nome = "Gustavo Augusto";
// // gustavo.Idade = 17;
// // gustavo.Logradouro = "Rua Mercedes Salano";
// // gustavo.Numero = 33;
// // gustavo.Logradouro = "Apto 33 - Bloco Marselha";

// // walyson.Nome = "Walyson Menezes";
// // walyson.Idade = 17;
// // walyson.Logradouro = "Monsenhor Pizzaro";
// // walyson.Numero = 27;

// // davi.Nome = "Davi Muniz";
// // davi.Idade = 17;


// // Guardando os dados na lista

// peoples.Add(gabriel);//0
// peoples.Add(gustavo);//1
// // peoples.Add(walyson);//2
// // peoples.Add(davi);//3

// Console.WriteLine($"Pessoa 1: {peoples[0].Nome}");
// Console.WriteLine($"Pessoa 2: {peoples[1].Nome}");
// Console.WriteLine($"Pessoa 3: {peoples[2].Nome}");
// Console.WriteLine($"Pessoa 4: {peoples[3].Nome}");


// Console.WriteLine();


// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spinola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// // PROFESSOR
// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua La de Casa";
// endProfAlex.Numero = 987;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Alexia Vitoria";

// Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da prof, {profAlexia.Nome}");



Carro fusca = new Carro();

fusca.Marca = "Wolkswagem";
fusca.Modelo = "Fusca";

Moto dominar400 = new Moto();

dominar400.Marca = "Bajaj";
dominar400.Modelo = "Dominar 400";

Aviao latam = new Aviao();

latam.Marca = "Boeing";
latam.Modelo = "Boeing 747";
latam.QtdAssentos = 200;
latam.QtdRodas = 3;

fusca.Ligar();
fusca.AbrirPortaMalas();

dominar400.Ligar();
dominar400.Empinar();

latam.Decolar();
latam.Pousando();
