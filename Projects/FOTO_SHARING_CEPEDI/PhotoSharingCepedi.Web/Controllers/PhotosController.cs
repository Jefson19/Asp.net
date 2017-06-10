using PhotoSharingCepedi.Models;
using PhotoSharingCepedi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoSharingCepedi.Web.Controllers
{
    public class PhotosController : Controller
    {
        private PhotoRepository photoRepository;

        public PhotosController()
        {
            if (photoRepository == null)
            {
                photoRepository = new PhotoRepository();
            }
        }

        // GET: Photos
        public ActionResult Index()
        {
            return View(photoRepository.Listar());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Photo photo, HttpPostedFileBase Image)
        {
            photo.CreateAt = DateTime.Now;
            photo.ModifiedAt = DateTime.Now;
            photo.User = User.Identity.Name;

            if (ModelState.IsValid)
            {
                if(Image != null)
                {
                    photo.MimeType = Image.ContentType;
                    photo.File = new byte[Image.ContentLength];
                    Image.InputStream.Read(photo.File, 0, Image.ContentLength);
                    photoRepository.Adicionar(photo);
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public FileContentResult ObterImagem(int id)
        {
            Photo photo = photoRepository.ObterPorId(id);
            if(photo != null)
            {
                return File(photo.File, photo.MimeType);
            }
            return null;
        }

    }
}