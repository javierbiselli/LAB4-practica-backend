﻿using Application.Dtos.Request;
using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB4_practica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices _movieServices;

        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        [HttpGet]
        public ActionResult<ICollection<Movie>> GetAll()
        {
            return Ok(_movieServices.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var mov = _movieServices.GetMovieById(id);
            if (mov == null)
            {
                return NotFound();
            }
            return Ok(mov);
        }

        [HttpPost]
        public ActionResult AddMovie([FromBody] MovieRequestDto data)
        {
            _movieServices.AddMovie(data);
            return Ok();
        }
    }
}