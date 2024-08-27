using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Movie
    {

        public Movie(string title, int directorId)
        {
            Title = title;
            Functions = new List<Function>();
            DirectorId = directorId;
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [ForeignKey("DirectorId")]
        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public ICollection<Function> Functions { get; set; }
    }
}
