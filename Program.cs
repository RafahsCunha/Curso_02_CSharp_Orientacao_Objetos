using Alura.Contas;
using Alura.Titular;
using System;

class Program
{
    static void Main(string[] args)
    {

        Cliente cliente1 = new Cliente(); // objeto cliente1
        cliente1.criaCliente("Rafael", "12344567", "Dev"); // adiciona valores no objeto cliente1 através do método criaCliente 

        ContaCorrente conta1 = new ContaCorrente(); // objeto conta1
        conta1.titular = cliente1; // objeto conta1.titular recebe o objeto cliente1. OBS titular é um objeto do tipo Cliente

        conta1.usuarioConta(cliente1, "Itaú-1234", "12334-4");

        conta1.setprimeiroDeposito(100);

        Console.WriteLine("Titular: "+conta1.titular.nome +
            "\nCPF: " + conta1.titular.cpf +
            "\nProfissao: "+ conta1.titular.profissao + 
            "\nAgencia: "+conta1.agencia +
            "\nConta Corrente: "+conta1.conta_corrente + 
            "\nSaldo: "+ conta1.getSaldo());


        Console.WriteLine();

        Cliente cliente2 = new Cliente();
        cliente2.criaCliente("Jennyfer","98765432-1","Vendedora");

        ContaCorrente conta2 = new ContaCorrente();
        conta2.titular = cliente2;

        conta2.usuarioConta(cliente2, "9875", "4567-8");

        conta2.setprimeiroDeposito(200);

        Console.WriteLine("Titular: " + conta2.titular.nome +
            "\nCPF: " + conta2.titular.cpf +
            "\nProfissao: " + conta2.titular.profissao +
            "\nAgencia: " + conta2.agencia +
            "\nConta Corrente: " + conta2.conta_corrente +
            "\nSaldo: " + conta2.getSaldo());


        //ContaCorrente conta1 = new ContaCorrente();
        //conta1.usuario("Rafael Henrique", "1234", "4321-2");
        //conta1.consultaSaldo();
        //conta1.primeiroDepositar(100.0);
        //conta1.consultaSaldo();
        //conta1.depositar(100.0);
        //conta1.sacar(30.0);
        //conta1.consultaSaldo();

        //Console.WriteLine("_________________________________");

        //ContaCorrente conta2 = new ContaCorrente();
        //conta2.usuario("Jennyfer Ribeiro", "9876", "0987-6");
        //conta2.primeiroDepositar(10);
        //conta2.consultaSaldo();

        //Console.WriteLine("_________________________________");


        //// Transferindo da conta1 para a conta2 depois que o objeto conta2 é criado
        //conta1.transferir(50.0, conta2);
        //conta1.consultaSaldo();
        //conta2.consultaSaldo();


    }
}
