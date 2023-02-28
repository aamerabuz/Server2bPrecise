using Microsoft.EntityFrameworkCore;

namespace Server2bPrecise.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Report> Reports { get; set; }
    
    }
}
