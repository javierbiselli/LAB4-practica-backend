using Application.Dtos.Request;
using Application.Dtos.Response;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieRepository _repository;

        public MovieServices(IMovieRepository repository) { _repository = repository; }

        //Metodo 1: Trae todos los movies
        public List<MovieDto> GetAll()
        {
            var movies = _repository.GetAllMovies();

            return movies.Select(m => new MovieDto
            {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description,
                Genre = m.Genre,
                isNational = m.IsNational,
                Director = new DirectorDto
                {
                    Id = m.Director.Id,
                    Name = m.Director.Name
                },
                Functions = m.Functions.Select(f => new FunctionDto
                {
                    Id = f.Id,
                    Date = f.Date,
                    Price = f.Price
                }).ToList()
            }).ToList();
        }

        public MovieDto? GetMovieById(int id)
        {
            var movie = _repository.GetMovieById(id);

            if (movie == null)
                return null;

            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                isNational = movie.IsNational,
                Director = new DirectorDto
                {
                    Id = movie.Director.Id,
                    Name = movie.Director.Name
                },
                Functions = movie.Functions.Select(f => new FunctionDto
                {
                    Id = f.Id,
                    Date = f.Date,
                    Price = f.Price
                }).ToList()
            };
        }


        //Metodo 3: Crea un movie

        public void AddMovie(MovieRequestDto data)
        {
            var obj = new Movie(data.Title, data.Description, data.Genre, data.DirectorId, data.IsNational)
            {
                Title = data.Title,
                Description = data.Description,
                Genre = data.Genre,
                DirectorId = data.DirectorId,
                IsNational = data.IsNational,
            };
            _repository.AddMovie(obj);

        }
    }
}
