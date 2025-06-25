using Project4_EntityFrameworkMovieCodeFirst.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkMovieCodeFirst.DAL.Context
{
    public class MovieContext:DbContext

    {
        public DbSet<Entities.Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
