using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Carro
    {
        public string fabricante { get; set; }
        public string modelo { get; set; }        
        public string versao { get; set; }
        public int ano { get; set; }
        public string cor { get; set; }
    }
}
