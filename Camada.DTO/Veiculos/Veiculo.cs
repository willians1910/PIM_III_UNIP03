using Camada.DTO.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO.Veiculos
{
    public class Veiculo
    {
        private string placa { get; set; }
        private string marca { get; set; }
        private string modelo { get; set; }
        private int renavam { get; set; }
        private string cor { get; set; }
        private Empresa empresa { get; set; }
    }
}
