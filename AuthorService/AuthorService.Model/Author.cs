using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorService.Model
{
    public class Author
    {
        [BsonElement("_id")]
        public BsonDouble _Id { get; set; }
        [BsonElement("id")]
        public int AuthorId { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }
        [BsonElement("gender")]
        public string Gender { get; set; }
        [BsonElement("books")]
        public string[] Books { get; set; }
    }
}
