using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotosharingCEPEDI.Web.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        public ActionResult Index()
        {
            return View();
        }
        //Criar
        
        public ActionResult Criar()
        {
            return View();
        }
    }
}