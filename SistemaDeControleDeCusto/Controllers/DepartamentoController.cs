using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaDeControleDeCusto.Base;
using SistemaDeControleDeCusto.Models;
using SistemaDeControleDeCusto.ViewModel;

namespace SistemaDeControleDeCusto.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly DepartamentoRepository _repository;

        public DepartamentoController(DepartamentoRepository repository)
        {
            _repository = repository;
        }

        public DepartamentoController() : this(new DepartamentoRepository()) { }

        public ActionResult Index()
        {
            var viewModel = new DepartamentoViewModel
            {
                Departamentos = _repository.GetAll()
            };

            return View(viewModel);
        }

        public ActionResult Novo(Departamento departamento)
        {
            _repository.Save(departamento);
            _repository.Commit();
            return RedirectToAction("Index");
        }
    }
}