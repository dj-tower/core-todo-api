using vue_core_todo.Models;
using Microsoft.EntityFrameworkCore;

namespace vue_core_todo {
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions options) : base(options) {

        }

        public DbSet<ChecklistItem> ChecklistItems { get; set; }

    }
}
