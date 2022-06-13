using SOLID;
using SOLIDKavramı.Data;

namespace SOLIDKavramı.Services
{
    internal class MovieService : IMovieService
    {
        private static List<Movie> MovieList; //Data 

        public List<GetMovieDto> GetMovies()    //HttpGet ile çalıştırılacak metot
        {
            var movieList = MovieList.Select(x => new GetMovieDto
            {
                Name = x.Name,
                CategoryId = x.CategoryId
            }).ToList();
            return movieList;
        }
    }
}
