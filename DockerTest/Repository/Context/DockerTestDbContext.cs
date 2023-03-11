using DockerTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerTest.Repository.Context
{
    public class DockerTestDbContext : DbContext
    {
        public DockerTestDbContext()
        {

        }

        public DockerTestDbContext(DbContextOptions<DockerTestDbContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
