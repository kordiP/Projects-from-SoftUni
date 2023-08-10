using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HomeAdminDemo.Data;

public partial class HomeAdminDemoContext : HomeAdminDemoIdentityContext
{
    

    public HomeAdminDemoContext(DbContextOptions<HomeAdminDemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<Block> Blocks { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Resident> Residents { get; set; }

    public virtual DbSet<Spending> Spendings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-LA33O3R;Database=HomeAdminDemo;Trusted_Connection=True;TrustServerCertificate=Yes;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Управител");

            entity.ToTable("Admin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.ApartmentId).HasColumnName("apartment_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");

            entity.HasOne(d => d.Apartment).WithMany(p => p.Admins)
                .HasForeignKey(d => d.ApartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admin_Apartment");
        });

        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Апартамент");

            entity.ToTable("Apartment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BlockId).HasColumnName("block_id");
            entity.Property(e => e.Debt)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("debt");
            entity.Property(e => e.Floor).HasColumnName("floor");
            entity.Property(e => e.Inhabitants).HasColumnName("inhabitants");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Quadrature).HasColumnName("quadrature");
            entity.Property(e => e.Tax)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("tax");

            entity.HasOne(d => d.Block).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Apartment_Block");
        });

        modelBuilder.Entity<Block>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Блок");

            entity.ToTable("Block");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Municupality)
                .HasMaxLength(50)
                .HasColumnName("municupality");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("region");
            entity.Property(e => e.Town)
                .HasMaxLength(50)
                .HasColumnName("town");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.ToTable("Meeting");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsFinished).HasColumnName("is_finished");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.ScheduledOn)
                .HasColumnType("datetime")
                .HasColumnName("scheduled_on");

            entity.HasOne(d => d.Admin).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Meeting_Admin");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("amount");
            entity.Property(e => e.ApartmentId).HasColumnName("apartment_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");

            entity.HasOne(d => d.Apartment).WithMany(p => p.Payments)
                .HasForeignKey(d => d.ApartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Apartment");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Project");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BlockId).HasColumnName("block_id");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("cost");
            entity.Property(e => e.Description).HasColumnName("description");

            entity.HasOne(d => d.Block).WithMany(p => p.Projects)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Project_Block");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("Question");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.MeetingId).HasColumnName("meeting_id");
            entity.Property(e => e.ResidentId).HasColumnName("resident_id");

            entity.HasOne(d => d.Meeting).WithMany(p => p.Questions)
                .HasForeignKey(d => d.MeetingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_Meeting");

            entity.HasOne(d => d.Resident).WithMany(p => p.Questions)
                .HasForeignKey(d => d.ResidentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_Resident");
        });

        modelBuilder.Entity<Resident>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Живущ");

            entity.ToTable("Resident");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.ApartmentId).HasColumnName("apartment_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");

            entity.HasOne(d => d.Apartment).WithMany(p => p.Residents)
                .HasForeignKey(d => d.ApartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Resident_Apartment");
        });

        modelBuilder.Entity<Spending>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Разходи");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ApartmentTax)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("apartment_tax");
            entity.Property(e => e.Cleaning)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("cleaning");
            entity.Property(e => e.Electricity)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("electricity");
            entity.Property(e => e.Lift)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("lift");
            entity.Property(e => e.Other)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("other");
            entity.Property(e => e.Parking)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("parking");
            entity.Property(e => e.PersonalTax)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("personal_tax");
            entity.Property(e => e.Repairs)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("repairs");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
