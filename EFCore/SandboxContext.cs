using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public class SandboxContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=.;Initial Catalog=EntityFrameworkTest;User ID=sa;Password=ABCabc123!");
    }
}
