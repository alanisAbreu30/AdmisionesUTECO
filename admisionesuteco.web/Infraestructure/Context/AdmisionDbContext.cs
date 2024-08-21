using admisionesuteco.web.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace admisionesuteco.web.Infraestructure.Context
{
    public class AdmisionDbContext : DbContext, IAdmisionDbContext
    {
        public AdmisionDbContext(DbContextOptions<AdmisionDbContext> options):base(options)
        {
            
        }
        public DbSet<Estudiante> Estudiante { get; set; }

       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(255);
                entity.Property(e => e.SelectedCareer).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DocumentPath).HasMaxLength(255);
                entity.Property(e => e.IsVerified).HasDefaultValue(false);
            });
            
        }
    }
}
