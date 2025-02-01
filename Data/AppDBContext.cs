using Microsoft.EntityFrameworkCore;
using TodoManager.Models;

namespace TodoManager.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<TodoManager.Models.Todo> Todos { get; set; }
    public DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>()
            .Property(t => t.TodoPriority)
            .HasConversion(
                v => v.ToString(),  // Convert enum to string
                v => (Todo.Priority)Enum.Parse(typeof(Todo.Priority), v)  // Convert string back to enum
            );
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
}

