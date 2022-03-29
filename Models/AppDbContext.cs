using Microsoft.EntityFrameworkCore;

namespace DockerEssentials.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto>? Produtos { get; set; }
    }
}