using DevTrackerWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DevTrackerWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Associate> Associates { get; set; }

        public DbSet<TaskType> TaskTypes { get; set; }

        public DbSet<MyTask> MyTasks { get; set; }

    }
}
