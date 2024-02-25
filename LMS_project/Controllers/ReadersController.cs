using LMS_project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllReaders() => Ok("All readers");

        [HttpGet("{id}")]
        public IActionResult GetReaderById(Reader reader) => Ok($"Here is the Reader with Id: {reader.IdReader}, and Name:{reader.NameReader}");

        [HttpPost]
        public IActionResult CreateReader(Reader reader) => Ok($"Created reader with Id: {reader.IdReader}, and Name: {reader.NameReader}");

        [HttpPut("{id}")]
        public IActionResult UpdateReader(Reader reader) => Ok($"Updated reader with Id: {reader.IdReader}, and Name: {reader.NameReader}");

        [HttpDelete("{id}")]
        public IActionResult DeleteReader(Reader reader) => Ok($"UPS!!!Deleted reader with Id: {reader.IdReader}, and Name: {reader.NameReader}");

    }
}
