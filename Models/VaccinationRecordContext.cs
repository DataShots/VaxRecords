using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VaxRecords.Models
{
    public partial class VaccinationRecordContext : DbContext
    {
        public VaccinationRecordContext()
        {
        }

        public VaccinationRecordContext(DbContextOptions<VaccinationRecordContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vaccines> Vaccines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaccines>(entity =>
            {
                entity.HasKey(e => e.VaccineId)
                    .HasName("PK__Vaccines__45DC68890D9F78BA");

                entity.Property(e => e.Clinician)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Vaccine)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
