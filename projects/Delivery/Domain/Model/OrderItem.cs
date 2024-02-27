namespace Delivery.Domain.Model;

public class OrderItem
{
   public Product Product { get; set; }
   public int Quantity { get; set; }
   public string Notes { get; set; }

   public double Subtotal {
    get { return Quantity * Product.Price; }
   }
}
