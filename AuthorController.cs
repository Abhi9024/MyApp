using AuthorService.Model;
using AuthorService.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AuthorService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AuthorController : ApiController
    {
        private IAuthorRepository _repo;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _repo = authorRepository;
        }
        
        [HttpGet]
        public IHttpActionResult GetAuthors()
        {
            var result = _repo.GetAuthors();
            return Json(result);
        }
    }
}
