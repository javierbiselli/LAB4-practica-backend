using Domain.Entities;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class FunctionRepository : IFunctionRepository
    {
        private readonly ApplicationContext _context;
        public FunctionRepository(ApplicationContext context)
        {
            _context = context;
        }
        
        
        //getAllFunction
        public List<Function> GetAllFunction()
        {
            return _context.Functions
                  .Include(f => f.Movie)
                  .ToList();
        }

        //getFunctionById
        public Function? GetFunctionById(int id)
        {
            return _context.Functions
                  .Include(f => f.Movie)
                  .FirstOrDefault(p => p.Id == id);
        }


        //createFunction
        public void AddFunction(Function function)
        {
            var movie = _context.Movies.Include(m => m.Functions)
                              .FirstOrDefault(m => m.Id == function.MovieId);

            if (movie == null)
            {
                throw new Exception("Movie not found");
            }

            // Agregar la nueva función
            movie.Functions.Add(function);

            // Guardar los cambios en el contexto
            _context.SaveChanges();
        }

        //updateProduct
        public void UpdateFunction(Function function)
        {
            _context.Functions.Update(function);
            _context.SaveChanges();
        }

        //deleteProduct
        public void DeleteFunction(Function function)
        {
            _context.Functions.Remove(function);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
