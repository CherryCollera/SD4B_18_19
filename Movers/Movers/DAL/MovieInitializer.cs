using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Movers.Models;

namespace Movers.DAL
{
    public class MovieInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            var movies = new List<Movie>
            {
            new Movie{Title="Carson",Description="Alexander"},
            new Movie{Title="Meredith",Description="Alonso"},
            new Movie{Title="Arturo",Description="Anand"},
            new Movie{Title="Gytis",Description="Barzdukas"},
            new Movie{Title="Yan",Description="Li"},
            new Movie{Title="Peggy",Description="Justice"},
            new Movie{Title="Laura",Description="Norman"},
            new Movie{Title="Nino",Description="Olivetto"}
            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
        }
    }
}