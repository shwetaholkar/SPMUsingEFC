using Microsoft.EntityFrameworkCore;
using SPMUsingEFC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC.DataAccess
{
    public class StudentPerformanceManagementContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Mark> Marks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True");
        }
    }
}

