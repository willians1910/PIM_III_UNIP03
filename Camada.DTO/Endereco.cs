using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada.DTO
{
    public class Endereco
    {
        //public string logradouro { get; set; }
        public int ENDE_ID { get; set; }
        public int ENDE_numero { get; set; }
        public string ENDE_complemento { get; set; }
        public string ENDE_bairro { get; set; }
        public int ENDE_cep { get; set; }
        public string municipio { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
