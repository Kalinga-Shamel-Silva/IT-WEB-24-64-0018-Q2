using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManager.Models;

namespace StudentManager.Data
{
    public class StudentManagerContext : DbContext
    {
        public StudentManagerContext (DbContextOptions<StudentManagerContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManager.Models.Course> Course { get; set; } = default!;
        public DbSet<StudentManager.Models.Student> Student { get; set; } = default!;
    }
}
