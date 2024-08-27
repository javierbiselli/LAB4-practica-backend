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
            return _context.Functions.ToList();
        }

        //getFunctionById
        public Function? GetFunctionById(int id)
        {
            return _context.Functions.FirstOrDefault(p => p.Id == id);
        }


        //createFunction
        public void AddFunction(Function function)
        {
            _context.Functions.Add(function);
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
