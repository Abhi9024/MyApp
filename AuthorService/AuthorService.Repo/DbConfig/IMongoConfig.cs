using AuthorService.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorService.Repo.DbConfig
{
    public interface IMongoConfig
    {
        MongoClient Client { get; }
        IMongoDatabase Db { get; }
        IMongoCollection<Author> Collection { get; }
    }
}
