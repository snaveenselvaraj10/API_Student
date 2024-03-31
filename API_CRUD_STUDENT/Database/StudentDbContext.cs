using API_CRUD_STUDENT.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace API_CRUD_STUDENT.Database
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
    }
}
