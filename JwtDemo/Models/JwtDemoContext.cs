using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtDemo.Models
{
    public class JwtDemoContext : IdentityDbContext
    {
        public JwtDemoContext(DbContextOptions<JwtDemoContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
