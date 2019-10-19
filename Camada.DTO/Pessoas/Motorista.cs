using Camada.DTO.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Pessoas
{
    class Motorista : Pessoa
    {
        private string chn;
        private Empresa empresa;

        public Motorista()
        {
            this.chn = string.Empty;
        }

        public string Chn
        {
            get { return chn; }
            set { chn = value; }
        }

        public Empresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

    }
}
