using Camada.DTO.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Veiculos
{
    class Veiculo
    {
        private string placa;
        private string marca;
        private string modelo;
        private int renavam;
        private string cor;
        private Empresa empresa;

        public string Placa { get => placa; set => placa = value; }
        public int Renavam { get => renavam; set => renavam = value; }
        public Empresa Empresa { get => empresa; set => empresa = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
