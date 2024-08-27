using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Function
    {
        public Function(DateTime date, double price, int movieId) 
        {
            Date = date;
            Price = price;
            MovieId = movieId;
        }

        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public double Price { get; set; }
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
