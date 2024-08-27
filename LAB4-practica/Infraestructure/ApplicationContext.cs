using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Function> Functions { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {


                modelBuilder.Entity<Movie>()
                    .HasMany(c => c.Functions)
                    .WithOne(o => o.Movie)
                    .HasForeignKey(o => o.MovieId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<Director>()
                    .HasMany(o => o.Movies)
                    .WithOne(p => p.Director)
                    .HasForeignKey(o => o.DirectorId)
                    .OnDelete(DeleteBehavior.Cascade);

                base.OnModelCreating(modelBuilder);
            }

        }
    }
}
