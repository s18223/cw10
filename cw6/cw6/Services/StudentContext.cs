using System;
using System.Data.Entity;
using cw4.Models;

namespace cw10.Services
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
