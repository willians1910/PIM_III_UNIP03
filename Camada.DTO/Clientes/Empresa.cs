using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Clientes
{
    class Empresa
    {
        private string cnpj;
        private string razaoSocial;
        private Endereco endereco;
        private string cep;
        private string telefone;

        public Empresa()
        {
            this.razaoSocial = string.Empty;
            this.cnpj = string.Empty;
            this.cep = string.Empty;
            this.telefone = string.Empty;
            this.endereco = new Endereco();
        }

        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
    }
}
