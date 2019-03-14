using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using SistemaDeControleDeCusto.Models;

namespace SistemaDeControleDeCusto.Base
{
    public abstract class Repository<T> where T : class
    {
        protected readonly SistemaContext Context;

        protected Repository(SistemaContext context)
        {
            Context = context;
        }

        protected Repository() : this(new SistemaContext()) { }

        public IList<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T Por(int id)
        {
            return Context.Set<T>().Find(id);
        }

        //public void Save(T entity)
        //{
        //    Context.Set<T>().Add(entity);
        //}

        public void Update(T entity)
        {
            var entry = Context.Entry(entity);
            Context.Set<T>().Attach(entity);
            entry.State = EntityState.Modified;
        }

        public void DeletarPor(int id)
        {
            var entity = Por(id);
            Context.Set<T>().Remove(entity);
        }

        public void Deletar(T entity)
        {
            var entry = Context.Entry(entity);
            Context.Set<T>().Attach(entity);
            entry.State = EntityState.Deleted;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}