using Ejercicio001.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ejercicio001.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Ejercicio001;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        public DbSet<Especie> Especies { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }

        //Add-Migration Inicial
        //Update-Database

    }
}
