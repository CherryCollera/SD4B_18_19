using Movers.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Movers.DAL
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieContext")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}