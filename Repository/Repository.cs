using Persistence;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Contexto _contexto;
        public Repository(Contexto contexto)
        {
            _contexto = contexto;
        }
        public void Add(T obj)
        {
            _contexto.Set<T>().Add(obj);
            _contexto.SaveChanges();
        }

        public T Get(int id)
        {
            return _contexto.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _contexto.Set<T>().ToList();
        }

        public void Remove(int obj)
        {
            var res = _contexto.Set<T>().Find(obj);
            _contexto.Set<T>().Remove(res);
            _contexto.SaveChanges();
        }

        public void Update(T obj)
        {
            _contexto.Set<T>().Update(obj);
            _contexto.SaveChanges();
        }
    }
}
