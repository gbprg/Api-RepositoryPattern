using Api_RepositoryPattern.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_RepositoryPattern.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
