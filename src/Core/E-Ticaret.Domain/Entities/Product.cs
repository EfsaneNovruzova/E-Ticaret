using static System.Net.Mime.MediaTypeNames;

namespace E_Ticaret.Domain.Entities;

public  class Product:BaseEntity
{
    public string Name { get; set; } = null!;
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public ICollection<Image> Images { get; set; }

    public ICollection<Favorite> Favorites { get; set; }

    public ICollection<OrderProduct> OrderProducts { get; set; }
    public ICollection<Review> Reviews { get; set; }

}
