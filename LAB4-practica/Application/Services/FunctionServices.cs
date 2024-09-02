using Application.Dtos.Request;
using Application.Dtos.Response;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services
{
    public class FunctionServices : IFunctionServices
    {
        private readonly IFunctionRepository _repository;

        public FunctionServices(IFunctionRepository repository) {_repository = repository; }


        public FunctionDto? GetFunctionById(int id)
        {
            var func = _repository.GetFunctionById(id);

            if (func == null)
                return null;

            return new FunctionDto
            {
                Id = func.Id,
                Date = func.Date,
                Price = func.Price,
                MovieTitle = func.Movie.Title // Asegúrate de que func.Movie no sea null
            };
        }

        //Metodo 3: Crea un funcion

        public bool AddFunction(FunctionRequestDto func)
        {
            var obj = new Function()
            {
                Date = func.Date,
                Price = func.Price,
                MovieId = func.MovieId
            };
            _repository.AddFunction(obj);
            _repository.SaveChanges();

            return (true);
        }

        //Metodo 4: Actualiza una funcion 
        public bool UpdateFunction(FunctionRequestDto data, int id)
        {
            var updateFuncValidate = _repository.GetFunctionById(id);

            if (updateFuncValidate != null)
            {
                updateFuncValidate.Price = data.Price;
                updateFuncValidate.Date = data.Date;

                _repository.UpdateFunction(updateFuncValidate);
                _repository.SaveChanges();
                return(true);
            }
            return (false);
        }

        //Metodo 5: Elimina un funcion
        public bool DeleteFunction(int id)
        {
            var deleteFuncValidate = _repository.GetFunctionById(id);

            if (deleteFuncValidate != null)
            {
                _repository.DeleteFunction(deleteFuncValidate);
                _repository.SaveChanges();
                return true;
            }
            return false;
        }

    }


}
