using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOLIDKavramı.Services;

namespace SOLIDKavramı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService service;

        public MoviesController(IMovieService service)
        {
            this.service = service;
        }

        [HttpGet("list")]
        public IActionResult GetMoviesList()
        {
            var data=service.GetMovies();
            return Ok(data);
        }
    }
}
