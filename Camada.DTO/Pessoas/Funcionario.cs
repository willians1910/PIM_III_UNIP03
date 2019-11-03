using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Pessoas
{
    public class Funcionario : Pessoa
    {
        public Perfil perfil { get; set; }
        public decimal salario { get; set; }


        public Funcionario()
        {
            this.perfil = new Perfil();
        }
    }
}
