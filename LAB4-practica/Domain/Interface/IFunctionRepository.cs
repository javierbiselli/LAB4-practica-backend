using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IFunctionRepository
    {
        public Function? GetFunctionById(int id);
        public void AddFunction(Function function);
        public void UpdateFunction(Function function);
        public void DeleteFunction(Function function);

        public void SaveChanges();
    }
}
