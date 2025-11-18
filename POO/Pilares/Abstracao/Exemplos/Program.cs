using Exemplos;

// Cachorro cachorro = new Cachorro();
// Gato gato = new Gato();

ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

Console.WriteLine($"Saldo Conta Corrente antes do saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupanca antes do saque: R${cp.Saldo}");

cc.Sacar(10);
cp.Sacar(5);

Console.WriteLine();

Console.WriteLine($"Saldo Conta Corrente apos o saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupanca apos o saque: R${cp.Saldo}");