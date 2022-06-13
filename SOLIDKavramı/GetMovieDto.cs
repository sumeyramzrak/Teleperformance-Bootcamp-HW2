using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOLID
{
    public class GetMovieDto
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }
    }
}
