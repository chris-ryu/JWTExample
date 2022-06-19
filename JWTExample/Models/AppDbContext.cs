using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace JWTExample.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var filePath = Path.Combine(Environment.CurrentDirectory, "Seed", "employees.json");
            Console.WriteLine($"filePath {filePath}");
            var books = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(filePath));
            modelBuilder.Entity<Employee>().HasData(books);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        
    }
}
