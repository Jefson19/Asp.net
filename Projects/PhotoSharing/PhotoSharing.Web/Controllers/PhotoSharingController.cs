using PhotoSharing.Repository;
using PhotSharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoSharing.Web.Controllers
{
    public class PhotoSharingController : Controller
    {
        // GET: PhotoSharing

        private PhotoRepository photoRepository;
        public PhotoSharingController()
        {
            if(photoRepository == null)
            {
                photoRepository = new PhotoRepository();
            }
        }
        public PartialViewResult Listar()
        {
            return PartialView(photoRepository.Listar());
        }

        public ActionResult Index()
        {   

           return View() ;
        }

        public ActionResult Criar() //mvc tab tab
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Photo photo, HttpPostedFileBase Image)
        {
            photo.createdAt = DateTime.Now;
            photo.ModifiedAt = DateTime.Now;
            photo.User = User.Identity.Name;

            if (ModelState.IsValid)
            {
                if(Image != null)
                {
                    photo.MimeType = Image.ContentType;
                    photo.File = new byte[Image.ContentLength]; //pegar o tamnho da imagem
                    Image.InputStream.Read(photo.File, 0, Image.ContentLength); //para copiar a imagem
                }

                photoRepository.Adicionar(photo);
                return RedirectToAction("Index");
            }
            return View(photo);
        }

        public FileContentResult ObterImagem(int id)
        {
            Photo photo = photoRepository.ObterPorId(id);

            if (photo != null)
            {
                return File(photo.File, photo.MimeType);
            }
            return null;
        }

        public ActionResult Visualizar (int id)
        {
            Photo photo = photoRepository.ObterPorId(id);
            return View(photo);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirma(int id)
        {
            photoRepository.Excluir(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            return View(photoRepository.ObterPorId(id));

        }
        
    }
}