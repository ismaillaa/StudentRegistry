using Microsoft.EntityFrameworkCore;
using StudentRegistry.Models;

namespace StudentRegistry.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> RegistryStudent { get; set; }
    }
}
