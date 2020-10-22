using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DDDContext _DDDContext = new DDDContext();
        public void Add(TEntity obj)
        {
            _DDDContext.Set<TEntity>().Add(obj);
            _DDDContext.SaveChanges();
        }
        public TEntity GetById(int id)
        {
            return _DDDContext.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _DDDContext.Set<TEntity>().ToList();
        }
        public void Update(TEntity obj)
        {
            _DDDContext.Entry(obj).State = EntityState.Modified;
            _DDDContext.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            _DDDContext.Set<TEntity>().Remove(obj);
            _DDDContext.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
