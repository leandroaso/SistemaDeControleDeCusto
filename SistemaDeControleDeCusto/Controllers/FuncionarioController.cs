using System.Web.Mvc;
using SistemaDeControleDeCusto.Base;
using SistemaDeControleDeCusto.Models;
using SistemaDeControleDeCusto.ViewModel;

namespace SistemaDeControleDeCusto.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        private readonly FuncionarioRepository _repository;

        public FuncionarioController(FuncionarioRepository repository)
        {
            _repository = repository;
        }

        public FuncionarioController() : this(new FuncionarioRepository()) { }

        public ActionResult Index()
        {
            ViewBag.Departamentos = new DepartamentoRepository().GetAll();
            var viewModel = new FuncionarioViewModel
            {
                Funcionarios = _repository.Listar()
            };

            return View(viewModel);
        }

        public ActionResult Novo(Funcionario funcionario)
        {
            _repository.Salvar(funcionario);
            _repository.Commit();
            return RedirectToAction("Index");
        }
    }
}