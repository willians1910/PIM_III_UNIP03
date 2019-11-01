using Camada.DTO.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Pessoas
{
    public class Motorista : Pessoa
    {
        public string cnh { get; set; }
        public Empresa empresa { get; set; }

        public Motorista()
        {
            this.empresa = new Empresa();
        }
    }
}
