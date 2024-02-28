namespace Delivery.Domain.Model;

public class OrderItem
{
   public int Quantity { get; set; }
   public string? Notes { get; set; }
   public Product Product { get; set; }

   public double Subtotal {
    get { return Quantity * Product.Price; }
   }
}
