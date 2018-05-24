﻿using Aula2205_Entity.Models;
using Aula2205_Entity.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula2205_Entity.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();

            List<Usuario> usuarios = contexto.Usuarios.ToList();

            return View(usuarios);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            Return View(usuario);
        }
    }
}