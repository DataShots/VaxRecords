
using VaxRecords.Models;
using Microsoft.EntityFrameworkCore;

namespace VaxRecords.Data
{
    public class VaccineContext : DbContext
    {
        public VaccineContext(DbContextOptions<VaccineContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Child>().ToTable("Child");
            modelBuilder.Entity<Vaccine>().ToTable("Vaccine");
        }
    }
}
