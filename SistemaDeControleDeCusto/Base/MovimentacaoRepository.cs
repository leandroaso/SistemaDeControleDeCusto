
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.Base
{
    public class MovimentacaoRepository : Repository<Movimentacao>
    {
        public IList<Movimentacao> Listar()
        {
            return Context.Movimentacoes.Include(m => m.Funcionario).ToList();
        }

        public IList<Movimentacao> Listar(int f, string d)
        {
            var query = Context.Movimentacoes.Include(m => m.Funcionario);

            if (f > 0)
                query = query.Where(m => m.Funcionario.ID == f);

            if (!string.IsNullOrWhiteSpace(d))
                query = query.Where(m => m.Descricao.Contains(d));

            return query.ToList();
        }
    }
}