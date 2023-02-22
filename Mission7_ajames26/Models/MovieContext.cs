using Microsoft.EntityFrameworkCore;
using Mission7_ajames26.Models;

namespace Mission7_ajames26.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>()
                .HasData
                (
                    new MovieCategory
                    {
                        Id = 1,
                        CategoryName = "Action"
                    },
                    new MovieCategory
                    {
                        Id = 2,
                        CategoryName = "Action/Adventure"
                    },
                    new MovieCategory
                    {
                        Id = 3,
                        CategoryName = "Action/Comedy"
                    }
                );

            modelBuilder.Entity<Movie>()
                .HasData
                (
                    new Movie
                    {
                        Id = 1,
                        Title = "The Spy Next Door",
                        MovieCategoryId = 3,
                        Year = 2010,
                        Director = "Brian Levant",
                        Rating = "PG",
                        Edited = false,
                    },
                    new Movie
                    {
                        Id = 2,
                        Title = "John Wick",
                        MovieCategoryId = 1,
                        Year = 2014,
                        Director = "Chad Stahelski",
                        Rating = "R",
                        Edited = false,
                    },
                    new Movie
                    {
                        Id = 3,
                        Title = "Raiders of the Lost Ark",
                        MovieCategoryId = 2,
                        Year = 1981,
                        Director = "Steven Spielberg",
                        Rating = "PG",
                        Edited = false,
                    }
                );
            ;
        }
    }
}