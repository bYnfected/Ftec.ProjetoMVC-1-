using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjetoMvc.WebSite.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {   
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autenticar(string usuario, string senha)
        {
            if(usuario.Equals("usuario") && senha.Equals("123456"))
            {
                Session["Usuario"] = usuario;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                Session["Usuario"] = null;
                return RedirectToAction("Login");
            }
            
        }
    }
}