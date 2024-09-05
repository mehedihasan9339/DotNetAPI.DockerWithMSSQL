using DotNetAPI.DockerWithMSSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetAPI.DockerWithMSSQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmployeeInfo> Employees { get; set; }
    }
}
