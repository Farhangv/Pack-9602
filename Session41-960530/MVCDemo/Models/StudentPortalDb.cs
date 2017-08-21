namespace MVCDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentPortalDb : DbContext
    {
        public StudentPortalDb()
            :base("StudentPortalDb")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Student>()
            //    .HasRequired(s => s.User)
            //    .WithOptional(u => u.Student);
        }
    }
}