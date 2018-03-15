using Microsoft.EntityFrameworkCore;

namespace TodoApp.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Todo> Todo { get; set; }
    }
}
