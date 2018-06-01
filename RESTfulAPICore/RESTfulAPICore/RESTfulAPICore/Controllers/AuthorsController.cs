using RESTfulAPICore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTfulAPICore.Models;
using RESTfulAPICore.Controllers.Helpers;
using AutoMapper;

namespace RESTfulAPICore.Controllers.Controllers
{
    [Route("api/authors")]
    public class AuthorsController : Controller
    {
        private ILibraryRepository _libraryRepository;

        public AuthorsController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
                var authorsFromRepo = _libraryRepository.GetAuthors();
                var authors = Mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo);
                return Ok(authors);        
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(Guid id)
        {
            if (!_libraryRepository.AuthorExists(id))
            {
                return NotFound();
            }

            var authorFromRepo = _libraryRepository.GetAuthor(id);
            var author = Mapper.Map<AuthorDto>(authorFromRepo);
            return new JsonResult(author);

        }


    }
}
