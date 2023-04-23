using ProjectLena.DataAccess.Abstract;
using ProjectLena.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        Context _context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = _context.Set<T>();
        }

        public void Delete(T p)
        {
            var deletedEntity=_context.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            _object.Remove(p);
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public void Insert(T p)
        {
            var addedEntity = _context.Entry(p);
            addedEntity.State = EntityState.Added;
            //_object.Add(p);
            _context.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = _context.Entry(p);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
