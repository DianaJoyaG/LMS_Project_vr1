using LMS_project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllBooks() => Ok("All books");

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id, Book book) => Ok($"Here is the Book with ID: {id}, Title: {book.Title}, Author: {book.Author}, Description: {book.Description}");

        [HttpPost]
        public IActionResult CreateBook(Book book) => Ok($"Created book with title: {book.Title}");

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book book) => Ok($"Yeah!!! Updated book with ID: {id}");

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id) => Ok($"UPS!!!Deleted book with ID: {id}");

    }
}
