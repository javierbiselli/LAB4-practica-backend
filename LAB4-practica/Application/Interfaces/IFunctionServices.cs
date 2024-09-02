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
    public interface IFunctionServices
    {
        FunctionDto? GetFunctionById(int id);
        bool AddFunction(FunctionRequestDto data);
        bool UpdateFunction(FunctionRequestDto data, int id);
        bool DeleteFunction(int id);


    }
}
