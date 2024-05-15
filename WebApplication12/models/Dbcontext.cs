namespace WebApplication12.models
{
    using Microsoft.EntityFrameworkCore;

    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }

}