using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCComplet.Models
{
    public class Pessoa
    {
        [Required]
        public string Nome{ get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento{ get; set; }
        public char Genero { get; set; }
        public decimal Saldo{ get; set; }
    }
}