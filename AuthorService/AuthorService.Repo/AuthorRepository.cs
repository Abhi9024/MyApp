using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthorService.Model;
using AuthorService.Repo.DbConfig;
using MongoDB.Driver;

namespace AuthorService.Repo
{
    public class AuthorRepository : IAuthorRepository
    {
        private IMongoCollection<Author> _collection;

        public AuthorRepository(IMongoConfig mongoConfig)
        {
            _collection = mongoConfig.Collection;
        }

        public void AddAuthor(Author author)
        {
            _collection.InsertOne(author);
        }

        public Author GetAuthor(int id)
        {
            var result = _collection.Find(a => a.AuthorId == id).FirstOrDefault();
            return result;
        }

        public List<Author> GetAuthors()
        {
            return _collection.Find(a => a.AuthorId > 0).ToList();
        }

        public bool UpdateAuthor(int id, Author author)
        {
           var result = _collection.ReplaceOne(doc => doc.AuthorId == id, author);
            return result.IsAcknowledged;
        }
    }
}
