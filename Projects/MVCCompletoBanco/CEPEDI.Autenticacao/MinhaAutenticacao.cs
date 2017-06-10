using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CEPEDI.Autenticacao
{
    public class MinhaAutenticacao : AuthorizeAttribute 
    {
        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            //            return base.AuthorizeCore(httpContext);
            // string usuario = httpContext.Session["usuario"].ToString();
            string usuario = httpContext.Session["usuario"] as string;

            return !string.IsNullOrWhiteSpace(usuario);
        }
    }
}
