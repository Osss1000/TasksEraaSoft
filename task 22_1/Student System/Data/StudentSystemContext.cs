using Microsoft.EntityFrameworkCore;
using P01_StudentsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentsSystem.Data
{
    internal class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; } 
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=localhost ; Initial Catalog=StudentSystem ; Integrated Security = True ; TrustServerCertificate = True ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().Property(e => e.PhoneNumber).HasMaxLength(10).IsUnicode(false).IsRequired(false);
            modelBuilder.Entity<Student>().Property(e => e.Name).HasColumnType("varchar(100)").IsUnicode(true);
            modelBuilder.Entity<Resource>().Property(e => e.URL).IsUnicode(false);
            modelBuilder.Entity<Resource>().Property(e => e.Name).HasColumnType("varchar(50)").IsUnicode(true);
            modelBuilder.Entity<StudentCourse>().HasKey(e => new { e.StudentId, e.CourseId });
            modelBuilder.Entity<Homework>().HasKey(e => e.HomeworkId);
            modelBuilder.Entity<Homework>().Property(e=>e.Content).IsUnicode(false);
            modelBuilder.Entity<Course>().Property(e => e.Name).HasColumnType("varchar(80)").IsUnicode(true);
            modelBuilder.Entity<Course>().Property(e => e.Description).IsUnicode(true).IsRequired(false);


        }
    }
}
