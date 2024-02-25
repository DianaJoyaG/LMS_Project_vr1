using LMS_project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowingController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBorrowings() => Ok("All borrowings");

        [HttpGet("{id}")]
        public IActionResult GetBorrowingById(int id, Borrowing borrowing) => Ok($"Here is a Borrowing with ID: {id}, Title: {borrowing.Title}");

        [HttpPost]
        public IActionResult CreateBorrowing(Borrowing borrowing) => Ok($"Created borrowing for book ID: {borrowing.IdBook}, by user Name: {borrowing.NameReader}");

        [HttpPut("{id}")]
        public IActionResult UpdateBorrowing(int id, Borrowing borrowing) => Ok($"Updated borrowing with ID: {id}, by Id Reader {borrowing.IdReader}");

        [HttpDelete("{id}")]
        public IActionResult DeleteBorrowing(int id, Borrowing borrowing) => Ok($"UPS!!!Deleted borrowing with ID: {id}, Title:{borrowing.Title}, Description:{borrowing.Description}");
    }
}
