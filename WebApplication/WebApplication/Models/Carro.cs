using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Carro
    {
        [Required (ErrorMessage="Campo Obrigatório!")]
        public string fabricante { get; set; }

        [Required (ErrorMessage="Campo Obrigatório!")]
        public string modelo { get; set; }
                
        public string versao { get; set; }
        
        [Required (ErrorMessage="Campo Obrigatório!")]
        public int ano { get; set; }

        public string cor { get; set; }
    }
}
