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
    public class MovimentacaoController : Controller
    {
        // GET: Movimentacao
        private readonly MovimentacaoRepository _repository;

        public MovimentacaoController(MovimentacaoRepository repository)
        {
            _repository = repository;
        }

        public MovimentacaoController() : this(new MovimentacaoRepository()) { }

        public ActionResult Index(string d = "", int f = 0)
        {
            ViewBag.Funcionarios = new FuncionarioRepository().GetAll();

            var movimentacoes = _repository.Listar(f,d);

            var viewModel = new MovimentacaoViewModel
            {
                Movimentacoes = movimentacoes
            };

            return View(viewModel);
        }

        public ActionResult Novo(Movimentacao movimentacao)
        {
            _repository.Save(movimentacao);
            _repository.Commit();
            return RedirectToAction("Index");
        }
    }
}