using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IMovieRepository
    {
        public List<Movie> GetAllMovies();
        public Movie? GetMovieById(int id);
        public void AddMovie(Movie data);
    }
}
