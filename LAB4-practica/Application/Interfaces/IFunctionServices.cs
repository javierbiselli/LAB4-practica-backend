using Application.Dtos.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFunctionServices
    {
        List<Function> GetAll();
        Function? GetFunctionById(int id);
        void AddFunction(FunctionRequestDto data);
        void UpdateFunction(Function data, int id);
        bool DeleteFunction(int id);


    }
}
