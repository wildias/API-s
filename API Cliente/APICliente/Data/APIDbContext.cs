using APICliente.Models;
using Microsoft.EntityFrameworkCore;

namespace APICliente.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) 
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
