namespace Delivery.Domain.Model;

public class Product
{
   public string Name { get; set; }
   public string Description { get; set; }
   public double Price { get; set; }
   public Restaurant Restaurant { get; set; }
}
