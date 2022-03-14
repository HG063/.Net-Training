using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EfCoreApp02.Models
{
    public partial class IncedoEmployeeDBContext : DbContext
    {
        public IncedoEmployeeDBContext()
        {
        }

        public IncedoEmployeeDBContext(DbContextOptions<IncedoEmployeeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCurrentBill> TblCurrentBills { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=G1-443HZH3-L\\SQLEXPRESS;database=IncedoEmployeeDB;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCurrentBill>(entity =>
            {
                entity.ToTable("tblCurrentBill");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Bu).HasColumnName("bu");

                entity.Property(e => e.Lmr).HasColumnName("lmr");

                entity.Property(e => e.Pmr).HasColumnName("pmr");

                entity.Property(e => e.Ur).HasColumnName("ur");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tblEmployees");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Job)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
