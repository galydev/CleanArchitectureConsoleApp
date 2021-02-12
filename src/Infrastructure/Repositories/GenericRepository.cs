using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Infrastructure.Data;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ApplicationContext _context;
        private DbSet<T> table;

        public GenericRepository()
        {
            this._context = new ApplicationContext();
            table = _context.Set<T>();
        }
        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}