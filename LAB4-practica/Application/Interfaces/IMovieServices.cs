using Application.Dtos.Request;
using Application.Dtos.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMovieServices
    {
        List<MovieDto> GetAll();
        MovieDto? GetMovieById(int id);
        void AddMovie(MovieRequestDto data);
    }
}
