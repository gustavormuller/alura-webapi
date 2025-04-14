using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using alura_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace filmesapi.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {
            
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}