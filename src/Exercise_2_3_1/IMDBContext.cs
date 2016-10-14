using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exercise_2_3_1
{
    public class ImdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=exercise_2_3;uid=admin;pwd=Fckfck123");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("movie");
            modelBuilder.Entity<Person>().ToTable("person");

            modelBuilder.Entity<Movie>().Property(m => m.Id).HasColumnName("id");
            modelBuilder.Entity<Movie>().Property(m => m.Title).HasColumnName("title");
            modelBuilder.Entity<Movie>().Property(m => m.Year).HasColumnName("year");

            modelBuilder.Entity<Person>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Person>().Property(p => p.Name).HasColumnName("name");
            modelBuilder.Entity<Person>().Property(p => p.Gender).HasColumnName("gender");

            base.OnModelCreating(modelBuilder);
        }
    }
}
