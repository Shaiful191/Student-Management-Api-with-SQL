using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetBasicCrudApi.Models
{
    public partial class studentsContext : DbContext
    {
        public studentsContext()
        {
        }

        public studentsContext(DbContextOptions<studentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Father_Name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
