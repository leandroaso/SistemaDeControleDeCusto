using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeControleDeCusto.Base
{
    public abstract class BaseRepository
    {
        protected readonly SistemaContext Context;

        protected BaseRepository(SistemaContext context)
        {
            Context = context;
        }
        protected BaseRepository() : this(new SistemaContext()) { }
    }
}