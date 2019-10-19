using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Pessoas
{
    public class Pessoa
    {
        private long cpf;
        private string rg;
        private string nome;
        private DateTime dataNasc;
        private char sexo;
        private Endereco endereco;
        private string cep;
        private string telefone;

        public Pessoa()
        {
            this.cpf = 0;
            this.nome = string.Empty;
            this.telefone = string.Empty;
            this.cep = string.Empty;
            this.endereco = new Endereco();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

    }
}
