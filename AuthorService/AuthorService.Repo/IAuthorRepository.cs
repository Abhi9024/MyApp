using AuthorService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorService.Repo
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);
        bool UpdateAuthor(int id, Author author);
        Author GetAuthor(int id);
        List<Author> GetAuthors();
    }
}
