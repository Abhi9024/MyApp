using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkInsert.Repo.GenericRepository
{
    public interface IGenericRepo<T> where T:class
    {
        IEnumerable<T> Read();
        bool Create(T obj);
        bool Update(T obj);
        bool Delete(T obj);
        T Search(int id);
    }
}
