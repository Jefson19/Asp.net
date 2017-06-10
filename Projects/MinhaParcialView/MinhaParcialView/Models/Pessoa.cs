using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MinhaParcialView.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        [Display (Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public char Genero { get; set; }
        public int Saldo { get; set; }

    }
}