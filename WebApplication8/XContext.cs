using Microsoft.EntityFrameworkCore;

namespace WebApplication8
{
    public class XContext: DbContext
    {
        public XContext(DbContextOptions<XContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
