using Microsoft.EntityFrameworkCore;


namespace ExpressionApp.Models
{
    public class MyDbContext:DbContext
    {
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro
        //https://www.youtube.com/watch?v=RYvuaU47h2w&index=9&list=PLRwVmtr-pp06SlwcsqhreZ2byuozdnPlg

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
