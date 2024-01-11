using Microsoft.EntityFrameworkCore;
using recordetur_api.Models;

namespace recordetur_api.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Viagens> Viagens { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
    }
}
