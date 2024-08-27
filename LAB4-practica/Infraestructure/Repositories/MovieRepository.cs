using Domain.Entities;
using Domain.Interface;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationContext _context;
        public MovieRepository(ApplicationContext context)
        {
            _context = context;
        }


        //getAllFunction
        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        //getFunctionById
        public Movie? GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(p => p.Id == id);
        }


        //createFunction
        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }
}
