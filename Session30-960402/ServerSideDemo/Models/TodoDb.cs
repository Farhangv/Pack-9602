namespace ServerSideDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TodoDb : DbContext
    {
        public TodoDb()
            : base("TodoDb")
        {
        }
        public DbSet<ToDo> Todos { get; set; }

    }
}