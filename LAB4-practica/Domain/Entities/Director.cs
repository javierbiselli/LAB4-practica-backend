using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Director
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movie { get; set; }
    }
}
