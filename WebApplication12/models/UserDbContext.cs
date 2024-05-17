namespace WebApplication12.models
{
    using Microsoft.EntityFrameworkCore;
    using System.Security.Policy;

    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Users>(entity =>
        //    {
        //        entity.HasKey(e => e.userId);
        //        entity.Property(e => e.name);
        //    });
        //}

        public DbSet<User> Users { get; set; }
    }

}