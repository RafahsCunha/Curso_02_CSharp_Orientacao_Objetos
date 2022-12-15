using Alura.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Contas
{
    class ContaCorrente
    {
        public ContaCorrente()
        {
            Console.WriteLine("******* BANCO JAAR *******");
        }
        public Cliente titular; // O atributo titular agora é um objeto do tipo Cliente, ou seja, ele pode receber os atributos da classe cliente 
        public string agencia;
        public string conta_corrente;
        private double saldo;


        public void usuarioConta(Cliente titular, string agencia, string conta_corrente) // o parãmetro titular é um objeto da classe Cliente, ele pode receber atributos da classe Cliente
        {
            this.titular = titular;
            this.agencia = agencia;
            this.conta_corrente = conta_corrente;

            //Console.WriteLine("Titular: " + this.nome + "\nAgencia: " + this.agencia +
            //   "\nConta Corrente: " + this.conta_corrente);
        }
        // Deposito obrigatório da interface IRegras
        public void setprimeiroDeposito(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
               this.saldo += valor;
            }
            
            //console.writeline("primeiro depósito efetuado no valor de r$ " + this.saldo);
        }

        public void setdepositar(double valorDepositado)
        {
            this.saldo += valorDepositado;
            Console.WriteLine("Deposito realizado com sucesso!");
        }

        public void sacar(double valorDoSaque)
        {
            if (valorDoSaque <= this.saldo)
            {
                this.saldo -= valorDoSaque;
                Console.WriteLine("Saque realizado com sucesso.. Valor: R$" + valorDoSaque);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente para Saque..");
            }

        }
        public void transferir(double valorTrasferido, ContaCorrente destino)
        {
            if (valorTrasferido <= saldo)
            {
                saldo -= valorTrasferido;
                destino.saldo += valorTrasferido;
                Console.WriteLine("Transferencia realizada com sucesso.. Valor: " + valorTrasferido);
            }
            else
            {
                Console.WriteLine("Transferencia não realizada, valor indisponível..");
            }
        }

        public double getSaldo()
        {
            return this.saldo;
            //Console.WriteLine("\nTitular da conta: " + this.titular.nome + "\nSaldo disponivel R$ " + this.saldo);
        }
    }
}