using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Data;

public partial class SchoolContext : DbContext
{
    public SchoolContext()
    {
    }

    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentsExam> StudentsExams { get; set; }

    public virtual DbSet<StudentsSubject> StudentsSubjects { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-LA33O3R;Database=School;Integrated Security=True;TrustServerCertificate=Yes").UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Exams__3214EC071BABC07D");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Subject).WithMany(p => p.Exams)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__Exams__SubjectId__398D8EEE");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3214EC0786EEECCC");

            entity.Property(e => e.Address).HasMaxLength(30);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.Phone).HasMaxLength(10);

            entity.HasMany(d => d.Teachers).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentsTeacher",
                    r => r.HasOne<Teacher>().WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_StudentsTeachers_Teachers"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_StudentsTeachers_Students"),
                    j =>
                    {
                        j.HasKey("StudentId", "TeacherId");
                        j.ToTable("StudentsTeachers");
                    });
        });

        modelBuilder.Entity<StudentsExam>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.ExamId });

            entity.Property(e => e.Grade).HasColumnType("decimal(15, 2)");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentsExams)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentsExams_Exams");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentsExams)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentsExams_Students");
        });

        modelBuilder.Entity<StudentsSubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3214EC07794FCE32");

            entity.Property(e => e.Grade).HasColumnType("decimal(15, 2)");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentsSubjects)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentsSubjects_Students");

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentsSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentsSubjects_Subjects");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subjects__3214EC072BA3B41C");

            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teachers__3214EC076E6606C8");

            entity.Property(e => e.Address).HasMaxLength(20);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Phone).HasMaxLength(10);

            entity.HasOne(d => d.Subject).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__Teachers__Subjec__3F466844");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
