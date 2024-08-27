using Application.Dtos.Request;
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

        //Metodo 1: Trae todos los productos
        public List<Function> GetAll()
        {

            return _repository.GetAllFunction();
        }

        //Metodo 2: Trae todos los productos

        public Function? GetFunctionById(int id)
        {
            var func = _repository.GetFunctionById(id);

            if (func != null)
            {
                return func;
            }
            else { return null; }
        }

        //Metodo 3: Crea un funcion

        public void AddFunction(FunctionRequestDto data)
        {
            var obj = new Function(data.Date, data.Price, data.MovieId)
            {
                Date = data.Date,
                Price = data.Price,
                MovieId = data.MovieId
            };
            _repository.AddFunction(obj);
  
        }

        //Metodo 4: Actualiza una funcion 
        public void UpdateFunction(Function data, int id)
        {
            var updateFuncValidate = _repository.GetFunctionById(id);

            if (updateFuncValidate != null)
            {
                updateFuncValidate.Price = data.Price;
                updateFuncValidate.Date = data.Date;

                _repository.UpdateFunction(updateFuncValidate);
                _repository.SaveChanges();


            }

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
