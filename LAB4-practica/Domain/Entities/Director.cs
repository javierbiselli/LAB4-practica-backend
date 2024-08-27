using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Director
    {
        public Director(string name)
        { 
            Name = name;
            Movies = new List<Movie>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
