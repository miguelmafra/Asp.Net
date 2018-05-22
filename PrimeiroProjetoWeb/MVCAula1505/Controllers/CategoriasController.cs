using MVCAula1505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAula1505.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            new Categoria()
            {
                Nome = "Casa"
            };

            categorias.Add(new Categoria() {Nome = "Casa" });
            categorias.Add(new Categoria() { Nome = "Carro" });
            categorias.Add(new Categoria() { Nome = "Trabalho" });
            categorias.Add(new Categoria() { Nome = "Família" });

            ViewBag.MinhasCategorias = categorias;


            return View();
        }
        public ActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Formulario(string nome, string descricao, bool ativo, string exemplotexto)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                // salvar no banco
            }
            return View(categoria);
        }

        public ActionResult Index2()
        {
            List<Categoria> categorias = new List<Categoria>();

            new Categoria()
            {
                Nome = "Casa"
            };

            categorias.Add(new Categoria() { Nome = "Casa" });
            categorias.Add(new Categoria() { Nome = "Carro" });
            categorias.Add(new Categoria() { Nome = "Trabalho" });
            categorias.Add(new Categoria() { Nome = "Família" });

            ViewBag.MinhasCategorias = categorias;


            return View(categorias);
        }
    }


}