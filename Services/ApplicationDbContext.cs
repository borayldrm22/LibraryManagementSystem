using Kutuphane2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane2.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        
        }
        
        public DbSet<Product> Products { get; set; }    
    }
}
