using MinhaParcialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaParcialView.Controllers
{
    public class HomeController : Controller
    {
        private static List<Pessoa> pessoas;
        public HomeController()
        {
            if (pessoas == null)
            {
                pessoas = new List<Pessoa>();
            }
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(pessoas);
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Cadastrar(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
            return Json(new { resultado = true });
        }
        public ActionResult Listar()
        {
            return PartialView(pessoas);
        }
    }
}