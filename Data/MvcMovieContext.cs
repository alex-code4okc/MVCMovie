using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    /* A database context class is needed to coordinate EF Core functionality
     * (Create, Read, Update, Delete) for the Movie model (or any other model).*/
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        //DbSet typically corresponds to a table
        // An entity corresponds to a record in the table
    }
}