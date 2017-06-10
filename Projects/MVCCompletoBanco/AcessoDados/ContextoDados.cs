using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcessoDados
{
    public class ContextoDados : DbContext
    {
        public ContextoDados():base("Poderosa")
        {
               
        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}