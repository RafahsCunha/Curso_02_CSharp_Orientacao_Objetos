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
            Console.WriteLine("******* BANCO JAAR *******"); // Construtor secundário ou normal
        }

        // ctor tab tab - atalho para criar um método construtor
        public ContaCorrente(int agencia) // Método Costrutor // Construtor principal é definido quando um construtor possui parâmetro
        {
            this.Numero_Agencia = agencia;
        }
        //public Cliente titular; // O atributo titular agora é um objeto do tipo Cliente, ou seja, ele pode receber os atributos da classe cliente 
        private int numero_agencia;
        //private string conta_corrente;
        private double saldo;



        //Propriedade do atributo numero_agencia

        // Conceito de propriedade: Ela pode substituir um método para desencapsular um atributo privado
        public int Numero_Agencia // Propriedade do atributo privado numero_agencia
        {
            get { return this.numero_agencia; }
            private set { // set visivel somente dentro da propria classe, ele está verificando se o valor da agencia é um valor positivo de 4 dígitos
                    if (value >= 1000)
                    {
                        this.numero_agencia = value;
                         
                    }
                }
        }

        // Propriedade do atributo privado conta_corrente
        public string Conta_Corrente { get; set; } // Conceito de propriedade auto implementada, ou seja, ela é criada em vez do atributo


        // Propriedade do atributo Titular
        public Cliente Titular { get; set; }

        public void setusuarioConta(Cliente titular, string conta_corrente) // o parãmetro titular é um objeto da classe Cliente, ele pode receber atributos da classe Cliente
        {
            this.Titular = titular;
            //this.Numero_Agencia = agencia;
            this.Conta_Corrente = conta_corrente;

            //Console.WriteLine("Titular: " + this.nome + "\nAgencia: " + this.agencia +
            // "\nConta Corrente: " + this.conta_corrente);
        }
        // Deposito obrigatório da interface IRegras
        public void setprimeiroDeposito(double valor)
        {
            if (valor < 0) // este if não deixa inserir um valor negativo no saldo
            {
                return; // não retorna nada
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