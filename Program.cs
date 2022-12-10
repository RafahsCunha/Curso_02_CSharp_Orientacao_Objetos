

using Curso_Alura_Orientacao_a_Objetos;
using System;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente();
        conta1.usuario("Rafael Henrique", "1234", "4321-2");
        conta1.consultaSaldo();
        conta1.primeiroDepositar(100.0);
        conta1.consultaSaldo();
        conta1.depositar(100.0);
        conta1.sacar(30.0);
        conta1.consultaSaldo();

        Console.WriteLine("_________________________________");

        ContaCorrente conta2 = new ContaCorrente();
        conta2.usuario("Jennyfer Ribeiro", "9876", "0987-6");
        conta2.primeiroDepositar(10);
        conta2.consultaSaldo();

        Console.WriteLine("_________________________________");


        // Transferindo da conta1 para a conta2 depois que o objeto conta2 é criado
        conta1.transferir(50.0, conta2);
        conta1.consultaSaldo();
        conta2.consultaSaldo();
    }
}
