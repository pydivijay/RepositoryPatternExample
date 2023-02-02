using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Models;

namespace RepositoryPatternExample.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
