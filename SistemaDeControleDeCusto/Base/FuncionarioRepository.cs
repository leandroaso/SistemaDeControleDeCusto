using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.Base
{
    public class FuncionarioRepository : Repository<Funcionario>
    {
        public void Salvar(Funcionario funcionario)
        {
            funcionario.Departamentos = GetDepartamentos(funcionario.DepartamentosID);
            Context.Funcionarios.Add(funcionario);
        }

        private IList<Departamento> GetDepartamentos(int[] ids)
        {
            if (ids == null || ids.Length == 0)
                return new List<Departamento>();

            return Context.Departamentos.Where(d => ids.Contains(d.ID)).ToList();
        }

        public IList<Funcionario> Listar()
        {
            return Context.Funcionarios.Include(f => f.Departamentos).ToList();
        }
    }
}