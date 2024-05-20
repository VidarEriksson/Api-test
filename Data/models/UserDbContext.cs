namespace Data.models;

using Microsoft.EntityFrameworkCore;
//options for the db

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