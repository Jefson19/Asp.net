using PhotoSharing.Repository;
using PhotSharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoSharing.Web.Controllers
{
    public class CommentsController : Controller
    {
        private CommentsRepository commentsRepository;
        public CommentsController()
        {
            commentsRepository = new CommentsRepository();
        }



        //[HttpPost]
        public ActionResult Criar()
        {
            return PartialView();
        }

        [ChildActionOnly]//so pode ser chamado por outra view
        public PartialViewResult _CommentsForPhoto(int PhotoId)
        {
            return ObterComentario(PhotoId);
        }

        private PartialViewResult ObterComentario(int PhotoId)
        {
            IEnumerable<Comment> comments = commentsRepository.Listar(c => c.PhotoId == PhotoId);
            ViewBag.PhotoId = PhotoId;
            return PartialView(comments);
        }

        [HttpPost]
        public PartialViewResult _CommentsForPhoto(Comment comment, int PhotoId)
        {
            CadastrarComentario(comment);

            IEnumerable<Comment> comments = commentsRepository.Listar(c => c.PhotoId == PhotoId);
          
            return PartialView(comments);
        }

        private void CadastrarComentario(Comment comment)
        {
            comment.User = User.Identity.Name;
            comment.createdAt = DateTime.Now;
            commentsRepository.Adicionar(comment);
        }
    }
}