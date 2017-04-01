using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BulkInsert.Repo.GenericRepository
{
    public interface IGenericRepo<T> where T:class
    {
        IEnumerable<T> Read(Expression<Func<T,bool>> criteria);
        void Create(T obj);
        void Update(T obj);
        void Delete(object id);
        T Search(object id);
    }
}
