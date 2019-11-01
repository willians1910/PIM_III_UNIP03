using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Clientes
{
    public class Empresa
    {
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public Endereco endereco { get; set; }
        public List<Telefone> telefones { get; }


        public Empresa()
        {
            this.endereco = new Endereco();
        }

        public void AddTelefone(Telefone t)
        {
            this.telefones.Add(t);
        }
    }
}
