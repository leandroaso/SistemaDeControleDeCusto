using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaDeControleDeCusto.Base;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo(Departamento departamento)
        {
            new DepartamentoRepository().Save(departamento);
            return RedirectToAction("Index");
        }
    }
}