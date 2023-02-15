using Microsoft.EntityFrameworkCore;

namespace Mission6_ajames26.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData
                (
                    new Movie
                    {
                        Id = 1,
                        Title = "The Spy Next Door",
                        Category = "Action/Comedy",
                        Year = 2010,
                        Director = "Brian Levant",
                        Rating = "PG",
                        Edited = false,
                    },
                    new Movie
                    {
                        Id = 2,
                        Title = "John Wick",
                        Category = "Action",
                        Year = 2014,
                        Director = "Chad Stahelski",
                        Rating = "R",
                        Edited = false,
                    },
                    new Movie
                    {
                        Id = 3,
                        Title = "Raiders of the Lost Ark",
                        Category = "Action/Adventure",
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