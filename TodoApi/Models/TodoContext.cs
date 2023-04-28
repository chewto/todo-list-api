using Microsoft.EntityFrameworkCore;
using TodoApi.models;

namespace TodoApi.models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        public DbSet<TodoApi.models.TodoItem>? TodoItem { get; set; }
    }
}
