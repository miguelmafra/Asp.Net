using Aula2205_Entity.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula2205_Entity.Controllers
{
    public class AtividadesController : Controller
    {
        // GET: Atividades
        public ActionResult Index()
        {
            MeuContexto contexto = new MeuContexto();

            List<Atividade> atividades = contexto.Atividades.ToList();

            return View(atividades);

        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Atividades.Add(atividade);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(atividade);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Atividade ati = contexto.Atividades.Find(id);

            if (ati == null)
            {
                return HttpNotFound();
            }

            return View(ati);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Atividade ati = contexto.Atividades.Find(id);

            if (ati == null)
            {
                return HttpNotFound();
            }

            return View(ati);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Atividade ati)
        {
            if (ModelState.IsValid)
            {
                MeuContexto contexto = new MeuContexto();
                contexto.Entry(ati).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ati);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MeuContexto contexto = new MeuContexto();

            Atividade ati = contexto.Atividades.Find(id);
            if (ati == null)
            {
                return HttpNotFound();
            }

            return View(ati);

        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeuContexto contexto = new MeuContexto();
            Atividade ati = contexto.Atividades.Find(id);

            contexto.Atividades.Remove(ati);
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
