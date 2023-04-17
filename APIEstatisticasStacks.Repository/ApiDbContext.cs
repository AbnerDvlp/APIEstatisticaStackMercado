using APIEstatisticasStacks.Repository.Entitys;
using Microsoft.EntityFrameworkCore;

namespace APIEstatisticasStacks.Repository
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EstatisticasStackVagas> EstatisticasStackVagas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}