using Newtonsoft.Json;

namespace JWTExample.Models
{
    public class DataSeeder
    {
        private readonly AppDbContext appDbContext;

        public DataSeeder(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void Seed()
        {
            if (!appDbContext.Employees.Any())
            {
                var filePath = Path.Combine(Environment.CurrentDirectory, "Seed", "employees.json");
                Console.WriteLine($"filePath {filePath}");
                var employees = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(filePath));
                appDbContext.Employees.AddRange(employees);
                appDbContext.SaveChanges();
            }
        }
    }
}
