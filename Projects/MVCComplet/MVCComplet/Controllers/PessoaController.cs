
using MVCComplet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCComplet.Controllers
{
    public class PessoaController : Controller
    {
        private static List<Pessoa> pessoas;
        public PessoaController()
        {
            if (pessoas == null)
            {
                pessoas = new List<Pessoa>();
                pessoas.Add(new Pessoa()
                {
                    Nome = "Jefson",
                    DataNascimento = DateTime.Now,
                    Genero = 'M',
                    Saldo = 1000000
                });
            }
        }
        
        // GET: Pessoa
        public ActionResult Index()
        {
            return View(pessoas);
        }
    }
}