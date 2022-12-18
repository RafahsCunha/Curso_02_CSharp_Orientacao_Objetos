using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Titular
{
    public class Cliente
    {
        //public string nome;
        //public string cpf;
        //public string profissao;

        //public void criaCliente(string nome, string cpf, string profissao)
        //{
        //    //this.nome = nome;
        //    //this.cpf = cpf;
        //    //this.profissao = profissao;

            //CODE SNIPED prop tab + tab recurso para criar o escopo de uma propriedade auto implementada

        // Propriedades publicas substituindo os atributos e métodos acima
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public void cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.Cpf = cpf; 
            this.Profissao = profissao;
        }
    }
}
