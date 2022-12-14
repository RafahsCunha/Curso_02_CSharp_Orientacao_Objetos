using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Alura
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        public void criaCliente(string nome, string cpf, string profissao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.profissao = profissao;
        }

    }
}
