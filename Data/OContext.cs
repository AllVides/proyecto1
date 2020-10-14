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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partida>()
                .HasOne(p => p.Usuario)
                .WithMany(b => b.Partidas)
                .HasForeignKey(d => d.IdUsuario);

            modelBuilder.Entity<Participante>()
                .HasKey(c => new { c.IdUsuario, c.IdTorneo });

            modelBuilder.Entity<Participante>()
                .HasOne(p => p.Usuario)
                .WithMany(b => b.Participantes);

            modelBuilder.Entity<Participante>()
                .HasOne(p => p.Torneo)
                .WithMany(b => b.Participantes);
                
                
        }
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Partida> Partida { get; set; }

        public DbSet<Torneo> Torneo { get; set; }

        public DbSet<Participante> Participante { get; set; }

    }
}
