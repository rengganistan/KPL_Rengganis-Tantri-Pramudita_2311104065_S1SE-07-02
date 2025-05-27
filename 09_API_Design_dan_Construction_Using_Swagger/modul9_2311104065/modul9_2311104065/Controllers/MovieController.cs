using Microsoft.AspNetCore.Mvc;
using modul9_2311104065.Models;

namespace modul9_2311104065.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" },
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" },
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" },
                Description = "When the menace known as the Joker wreaks havoc and chaos on Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
            }
        };

        // GET /api/Movies
        [HttpGet]
        public ActionResult<List<Movie>> GetMovies()
        {
            return movies;
        }

        // GET /api/Movies/{id}
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound();
            }
            return movies[id];
        }

        // POST /api/Movies
        [HttpPost]
        public ActionResult<List<Movie>> PostMovie([FromBody] Movie movie)
        {
            movies.Add(movie);
            return movies;
        }

        // DELETE /api/Movies/{id}
        [HttpDelete("{id}")]
        public ActionResult<List<Movie>> DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound();
            }
            movies.RemoveAt(id);
            return movies;
        }
    }
}
