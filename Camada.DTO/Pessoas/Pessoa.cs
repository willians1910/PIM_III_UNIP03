using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Pessoas
{
    public class Pessoa: Telefone
    {

        public int ID { get; set; }
        public int cpf { get; set; }
        public string rg { get; set; }
        public string nome { get; set; }
        public DateTime dataNasc { get; set; }
        public string sexo { get; set; }
        public Endereco endereco { get; set; }
        public List<Telefone> telefone { get; }

        public Pessoa()
        {
            this.endereco = new Endereco();    
            this .telefone = new List<Telefone>();
        }

        //public void AddTelefone(Telefone t)
        //{
        //    this.telefone.Add(t);
        //}
    }
}
