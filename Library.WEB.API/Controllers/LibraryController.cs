using Library.WEB.API.Models;
using Library.WEB.API.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.WEB.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [AllowAnonymous]
        [HttpGet("GetBookList")]
        public IActionResult GetBookList()
        {
            return Ok(_libraryService.GetBookList().Result);
        }

    }
}
