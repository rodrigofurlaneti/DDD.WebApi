using DDD.Aplication.Interfaces;
using Domain.Services;
using System;
using System.Collections.Generic;
namespace DDD.Aplication.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly ServiceBase<TEntity> _serviceBase;
        public AppServiceBase(ServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }
        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }
        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }
        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
