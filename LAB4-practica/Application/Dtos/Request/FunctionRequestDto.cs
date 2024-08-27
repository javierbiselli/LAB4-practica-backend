using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Request
{
    public class FunctionRequestDto
    {
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int MovieId { get; set; }
    }
}
