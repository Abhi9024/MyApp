using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthorService.Model;
using MongoDB.Driver;

namespace AuthorService.Repo.DbConfig
{
    public class MongoConfig : IMongoConfig
    {
        //db constants
        string connString = "mongodb://localhost:27017";
        string dbName = "ReactApp";
        string coll = "Author";


        public MongoClient Client => new MongoClient(connString);

        public IMongoDatabase Db => Client.GetDatabase(dbName);

        public IMongoCollection<Author> Collection => Db.GetCollection<Author>(coll);
    }
}
