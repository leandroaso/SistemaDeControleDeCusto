using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.ViewModel
{
    public class FuncionarioViewModel
    {
        public IList<Funcionario> Funcionarios { get; set; }
    }
}