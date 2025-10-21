/* Faça um programa que receba 4 notas de um aluno, calcule e imprimaa media 
aritmetica das notas e a mensagem de APROVADO para media superior ou igual a
7,0 RECUPERAÇÃO para notas entre 5,0 e 7,0 ou a mensagem de REPROVADO para media inferior a 5,0*/

double n1, n2, n3, n4;

Console.WriteLine("Digite a primeira nota:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
n3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota:");
n4 = double.Parse(Console.ReadLine());

double media = n1 + n2 + n3 + n4 / 4;

if (media >= 7.0)
{
    Console.WriteLine($"Aprovado!!"+ media);
}
else if (media >= 5.0)
{
    Console.WriteLine($"Recuperação!!"+ media);
}
else
{
     Console.WriteLine("Reprovado"+ media);
}