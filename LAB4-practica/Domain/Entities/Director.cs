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
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movie { get; set; }
    }
}
