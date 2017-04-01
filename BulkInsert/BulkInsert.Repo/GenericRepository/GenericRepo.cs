using BulkInsert.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;


namespace BulkInsert.Repo.GenericRepository
{
    class GenericRepo<T>: IGenericRepo<T> where T:class
    {

        readonly AdventureWorks2008R2Context _dbContext;

        public GenericRepo(AdventureWorks2008R2Context dbContext)
       {
         _dbContext = dbContext;
       }

        public IEnumerable<T> Read(Expression<Func<T, bool>> criteria)
        {
            var values = _dbContext.Set<T>().Where(criteria).ToList();
            return values;
        }

        public void Create(T obj)
        {
            if (_dbContext.Entry<T>(obj).State == EntityState.Detached)
                _dbContext.Entry<T>(obj).State = EntityState.Added;
            else
                _dbContext.Set<T>().Add(obj);

            _dbContext.SaveChanges();
        }

        public void Update(T obj)
        {
            _dbContext.Set<T>().Attach(obj);
            _dbContext.Entry<T>(obj).State = EntityState.Modified;

            _dbContext.SaveChanges();
        }

        public void Delete(object id)
        {
            _dbContext.Set<T>().Remove(Search(id));
            _dbContext.SaveChanges();
        }

        public T Search(object id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            return entity;
        }
    }
}
