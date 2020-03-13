using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookcrud.Data;
using bookcrud.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        BookContext _bookContext;

        public BooksController(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
        // GET: api/Books
        [HttpGet]
            public IActionResult GetBooks()
            {
                var books = _bookContext.Books;
                return Ok(books);
            }
        

        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetBook(int id)
        {
            var book = _bookContext.Books.Find(id);
            if (book == null)
            {
                return NotFound("No record found...");
            }
            return Ok(book);
        }

        [AllowAnonymous]
        // POST: api/Books
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            _bookContext.Books.Add(book);
            _bookContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);


        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Book book)
        {
        var entity = _bookContext.Books.Find(id);
            if(entity == null)
            {
                return NotFound("The book you are looking for can't be found");
            }
            else
            {
                entity.Author = book.Author;
                //entity.Id = book.Id;
                entity.Publisher = book.Publisher;
                entity.Title = book.Title;
                _bookContext.SaveChanges();
                return Ok("Your record has been updated");
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _bookContext.Books.Find(id);
            if (entity == null)
            {
                return NotFound("no record foound against this id");
            }
            else
            {
                _bookContext.Books.Remove(entity);
                _bookContext.SaveChanges();
                return Ok("Code deleted");
            }
        }
    }
}
