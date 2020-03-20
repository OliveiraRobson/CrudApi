using CrudBase.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudBase.Data.Context
{
    public class BaseRepository<T> where T : class,IBaseRepository<T>
    {
        readonly CrudContext _context;
        public BaseRepository(CrudContext context)
        {
            _context = context;
        }
        public void Delete(object id)
        {
            T existing = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();

        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);

        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Set<T>().Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;

        }
    }
}
