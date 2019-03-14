using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.Base
{
    public class DepartamentoRepository : Repository<Departamento>
    {
        public void Save(Departamento departamento)
        {
            Context.Departamentos.Add(departamento);
        }
    }
}