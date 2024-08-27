using Application.Dtos.Request;
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
        public List<Movie> GetAll()
        {

            return _repository.GetAllMovies();
        }

        //Metodo 2: Trae una movies

        public Movie? GetMovieById(int id)
        {
            var mov = _repository.GetMovieById(id);

            if (mov != null)
            {
                return mov;
            }
            else { return null; }
        }

        //Metodo 3: Crea un movie

        public void AddMovie(MovieRequestDto data)
        {
            var obj = new Movie(data.Title, data.DirectorId)
            {
                Title = data.Title,
                DirectorId = data.DirectorId,
            };
            _repository.AddMovie(obj);

        }
    }
}
