using BackendAjsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace BackendAjsAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Modelos
        public DbSet<User> Users { get; set; }

        //Constraints
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasIndex(b => new { b.Email }).IsUnique();

            modelBuilder
                .Entity<User>()
                .ToTable(b => b.HasCheckConstraint("CK_User_Sexo", "Sexo in ('m','f')"));

            modelBuilder
                .Entity<User>()
                .ToTable(b => b.HasCheckConstraint("CK_User_Tipo", "Tipo in ('adm','apo','doc')"));

            modelBuilder
                .Entity<User>()
                .Property(x => x.FechaCreacion).HasDefaultValueSql("getdate()");

            modelBuilder
                .Entity<User>()
                .Property(x => x.FechaModificacion).HasDefaultValueSql("getdate()");
        }
    }
}
