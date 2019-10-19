using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Pessoas
{
    class Funcionario : Pessoa
    {
        private Perfil perfil;

        public Funcionario()
        {
            this.perfil = new Perfil();
        }

        public Perfil Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
    }
}
