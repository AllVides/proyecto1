using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto1.Models;

namespace proyecto1.Data
{
    public class OContext : DbContext
    {
        public OContext(DbContextOptions<OContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Partida> Paritda { get; set; }

        public DbSet<Ruta> Ruta { get; set; }
    }
}
