﻿using MVCAula1505.Models;
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
    }

}