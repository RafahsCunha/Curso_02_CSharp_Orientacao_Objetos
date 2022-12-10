using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Alura_Orientacao_a_Objetos
{
    class ContaCorrente : IRegras
    {
        public ContaCorrente()
        {
            Console.WriteLine("******* BANCO JAAR *******");
        }
        private string nome;
        private string agencia;
        private string conta_corrente;
        private double saldo;


        public void usuario(string nome, string agencia, string conta_corrente)
        {
            this.nome = nome;
            this.agencia = agencia;
            this.conta_corrente = conta_corrente;

            Console.WriteLine("Titular: " + this.nome + "\nAgencia: " + this.agencia +
               "\nConta Corrente: " + this.conta_corrente);
        }
        // Deposito obrigatório da interface IRegras
        public void primeiroDepositar(double valor)
        {
            this.saldo = valor;
            Console.WriteLine("Primeiro depósito efetuado no valor de R$ " + this.saldo);
        }

        public double depositar(double valorDepositado)
        {
            return this.saldo += valorDepositado;

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
            if (valorTrasferido <= this.saldo)
            {
                this.saldo -= valorTrasferido;
                destino.saldo += valorTrasferido;
                Console.WriteLine("Transferencia realizada com sucesso.. Valor: " + valorTrasferido);
            }
            else
            {
                Console.WriteLine("Transferencia não realizada, valor indisponível..");
            }
        }

        public void consultaSaldo()
        {
            Console.WriteLine("\nTitular da conta: "+this.nome + "\nSaldo disponivel R$ " + this.saldo);
        }
    }
}