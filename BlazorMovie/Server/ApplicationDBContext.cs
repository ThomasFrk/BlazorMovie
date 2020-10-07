using BlazorMovie.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Server
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :
            base(options)
        {

        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Products { get; set; }
    }
}
