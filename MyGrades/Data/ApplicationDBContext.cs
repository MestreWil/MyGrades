using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyGrades.Models;

namespace MyGrades.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Student> Students {  get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjets { get; set; }
        public DbSet<Grades> Grades { get; set; }

    }
}
