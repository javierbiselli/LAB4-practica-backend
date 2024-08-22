using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Function
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public double Price { get; set; }

        public ICollection<Movie> Movie { get; set; }
        public ICollection<Director> DirectorFilm { get; set; }


    }
}
