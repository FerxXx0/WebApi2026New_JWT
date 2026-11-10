using Microsoft.EntityFrameworkCore;
using WebApi2026New.Models;

namespace WebApi2026New.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Mapeo explícito a los nombres de tablas en SQL Server
            modelBuilder.Entity<Persona>().ToTable("Personas");
            modelBuilder.Entity<Direccion>().ToTable("Direcciones");
        }
    }
}