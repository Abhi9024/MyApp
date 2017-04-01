using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkInsert.Repo.GenericRepository
{
    class GenericRepo<T>: IGenericRepo<T> where T:class
    {
        public IEnumerable<T> Read()
        {
            throw new NotImplementedException();
        }

        public bool Create(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public T Search(int id)
        {
            throw new NotImplementedException();
        }
    }
}
