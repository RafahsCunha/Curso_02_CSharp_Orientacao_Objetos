using Alura.Contas;
using Alura.Titular;
using System;

class Program
{
    static void Main(string[] args)
    {

        Cliente cliente1 = new Cliente(); // objeto cliente1
        //cliente1.criaCliente("Rafael", "12344567", "Dev"); // adiciona valores no objeto cliente1 através do método criaCliente 
        cliente1.cliente("Rafael Henrique", "123456789-9","Desenvolvedor");
        ContaCorrente conta1 = new ContaCorrente(); // objeto conta1
        conta1.Titular = cliente1; // objeto conta1.titular recebe o objeto cliente1. OBS titular é um objeto do tipo Cliente

        conta1.setusuarioConta(cliente1, 1234, "12334-4");

        conta1.setprimeiroDeposito(100);

        Console.WriteLine("Titular: "+conta1.Titular.Nome +
            "\nCPF: " + conta1.Titular.Cpf +
            "\nProfissao: "+ conta1.Titular.Profissao + 
            "\nAgencia: "+conta1.Numero_Agencia + // Acessando a Propriedade. As iniciais são maiúscula. Tipo Pascal Case
            "\nConta Corrente: "+conta1.Conta_Corrente + // Acessando a Propriedade. As iniciais são maiúscula. Tipo Pascal Case
            "\nSaldo: " + conta1.getSaldo());


        Console.WriteLine();

        Cliente cliente2 = new Cliente();
        //cliente2.criaCliente("Jennyfer","98765432-1","Vendedora");
        cliente2.cliente("Jennyfer Ribeiro", "987654321-1", "Vendedora");

        ContaCorrente conta2 = new ContaCorrente();
        conta2.Titular = cliente2;

        conta2.setusuarioConta(cliente2, 9875, "4567-8");

        conta2.setprimeiroDeposito(200);

        Console.WriteLine("Titular: " + conta2.Titular.Nome +                                   
            "\nCPF: " + conta2.Titular.Cpf +
            "\nProfissao: " + conta2.Titular.Profissao +
            "\nAgencia: " + conta2.Numero_Agencia + // Acessando a Propriedade. As iniciais são maiúscula. Tipo Pascal Case
            "\nConta Corrente: " + conta2.Conta_Corrente + // Acessando a Propriedade. As iniciais são maiúscula. Tipo Pascal Case
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
