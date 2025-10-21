﻿Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as bos vindas a voce!!");

Console.WriteLine($"Por favor escolha uma opcao abaixo: ");
Console.WriteLine($"1 - Saudar com nome");
Console.WriteLine($"2 - Saudar com sobrenome");
Console.WriteLine($"3 - Saudar com nome e sobrenome  ");
Console.WriteLine($"0 - Apenas saudacao generica");

int opcao = 0;

switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;

    case 1:
        SaudarComNome(nome);
        break;

    case 2:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {nomeCompleto}");
        break;

    case 3:
        SaudarComSobrenome(sobrenome);
        break;

    default:
        break;
}

void SaudarComSobrenome (string sobrenomeRecebido)
{
    Console.WriteLine($"Ola, Seja bem-vindo {sobrenomeRecebido}");
}


void SaudacaoGenerica()
{
    Console.WriteLine($"Ola, Seja bem vindo ao nosso programa, tenha um otimo dia :) ");
}


void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

string DevolveNomeCompleto (string nomeRecebido, string sobrenomeRecebido)
{
        return $"{nomeRecebido} {sobrenomeRecebido}";

}