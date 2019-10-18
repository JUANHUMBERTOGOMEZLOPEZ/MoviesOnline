using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesOnline.Data.Entities;

namespace MoviesOnline.Data.Repositories
{
    public class MoviesDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
