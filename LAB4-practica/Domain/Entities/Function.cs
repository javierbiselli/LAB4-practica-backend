using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public double Price { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        //public Movie Movie { get; set; }

    }
}
