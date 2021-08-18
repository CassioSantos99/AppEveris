using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEveris.Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public long cep { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
