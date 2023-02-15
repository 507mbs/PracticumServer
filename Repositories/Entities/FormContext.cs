using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Entities;

public partial class FormContext : DbContext
{
    public FormContext()
    {
    }

    public FormContext(DbContextOptions<FormContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Detail> Details { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-QM3UF42;Initial Catalog=form;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasKey(e => e.Identity);

            entity.Property(e => e.Identity).HasMaxLength(10);
            entity.Property(e => e.BornDate).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ParentId)
                .HasMaxLength(10)
                .HasColumnName("parentId");

            entity.HasOne(d => d.Parent).WithMany(p => p.Children)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Children_Details1");
        });

        modelBuilder.Entity<Detail>(entity =>
        {
            entity.HasKey(e => e.Idenentity);

            entity.Property(e => e.Idenentity).HasMaxLength(10);
            entity.Property(e => e.BornDate).HasColumnType("date");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Hmo)
                .HasMaxLength(20)
                .HasColumnName("HMO");
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
