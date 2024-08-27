using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Response

{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DirectorDto Director { get; set; }
        public List<FunctionDto>? Functions { get; set; }
    }
}
