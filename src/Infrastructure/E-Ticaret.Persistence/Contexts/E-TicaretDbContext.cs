using E_Ticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Persistence.Contexts;

public class E_TicaretDbContext:DbContext
{
    public E_TicaretDbContext(DbContextOptions<E_TicaretDbContext>options)
    {
        
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Favourite> Favourites { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }


}
