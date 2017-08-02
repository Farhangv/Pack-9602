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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Student", "Students");
            modelBuilder.Entity<Contact>().ToTable("Contact", "Students");
            //modelBuilder.Entity<نام کلاس انتیتی>().ToTable("<Table Name>", "<Schema Name>");

        }
    }
}