using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ListaComprasController : Controller
    {
        // GET: ListaCompra
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Quantidade = 5;
            return View();
        }
        [HttpPost]
        public ActionResult Index(int quantidade)
        {
            ViewBag.Quantidade = quantidade;
            return View();
        }
    }
}
}