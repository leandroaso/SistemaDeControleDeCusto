using System.Collections.Generic;
using System.Linq;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.Base
{
    public class DepartamentoRepository : Repository<Departamento>
    {
        public IList<Departamento> Listar()
        {
            return Context.Departamentos.ToArray();
        }
    }
}