using Application.Dtos.Response;
using Domain.Entities;
using Domain.Interface;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
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

        public List<Movie> GetAllMovies()
        {
            return _context.Movies
                           .Include(m => m.Functions) // Incluye las funciones asociadas
                           .Include(m => m.Director) // Incluye el director de la película
                           .ToList();
        }

        public Movie? GetMovieById(int id)
        {
            return _context.Movies
                           .Include(m => m.Functions)
                           .ThenInclude(f => f.Movie)
                           .Include(m => m.Director)
                           .FirstOrDefault(m => m.Id == id);
        }


        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }
}
