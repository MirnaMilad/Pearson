using Microsoft.EntityFrameworkCore;
using StudentsScores.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.Repository.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<ScoreSubject> Scores { get; set; }
        public DbSet <English> English { get; set; }
        public DbSet<Maths> Maths { get; set; }
        public DbSet<Science> Science { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
