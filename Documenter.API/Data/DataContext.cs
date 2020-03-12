using Microsoft.EntityFrameworkCore;
using Documenter.API.Models;
namespace Documenter.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}