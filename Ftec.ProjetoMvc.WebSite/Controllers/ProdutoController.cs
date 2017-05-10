using Ftec.ProjetoMvc.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjetoMvc.WebSite.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {

            if (Session["Usuario"] == null)
            {
                return RedirectToAction("Login", "Login");
            }

            if (Session["produtos"] == null)
            {
                List<Produto> produtos = MockFactory.MockFactory.GerarListaProdutos(10);
                Session["produtos"] = produtos;
            }
            

            ViewBag.Produtos = (List<Produto>)Session["produtos"];

            return View();
        }

        public ActionResult Cadastro()
        {
            List<Categoria> categorias = MockFactory.MockFactory.GerarListaCategorias(10);

            ViewBag.Categorias = categorias;

            return View();
        }

       /* public ActionResult Gravar(string nome, float preco, int quantidade  )
        {
            return RedirectToAction("Index");
        }
        */

        [HttpPost]
        public ActionResult Gravar(Produto produto, Guid CategoriaId)
        {
            produto.Id = Guid.NewGuid();
            produto.Categoria = new Categoria()
            {
                Id = CategoriaId
            };

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Alterar(Produto produto, Guid CategoriaId)
        {
            produto.Categoria = new Categoria()
            {
                Id = CategoriaId
            };

            return RedirectToAction("Index");
        }

        public ActionResult Modificar(Guid id)
        {
            List<Categoria> categorias = MockFactory.MockFactory.GerarListaCategorias(10);
            ViewBag.Categorias = categorias;

            Produto prod = new Produto()
            {
                Id = id,
                Categoria = new Categoria(),
                Nome = "Prduto 1",
                Preco = 1,
                Quantidade = 10
            };

            ViewBag.Produto = prod;

            return View();
        }

        public ActionResult DecrementaEstoque (Guid Id)
        {
            List<Produto> produtos = (List<Produto>)Session["produtos"];

            Produto prod = produtos.Where(p => p.Id == Id).FirstOrDefault();

            if(prod != null)
            {
                prod.Quantidade--;
            }

            return Json(prod);
        }


    }
}