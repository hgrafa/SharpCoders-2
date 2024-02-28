namespace Delivery.Domain.Model;

public class Invoice
{
   public double BasicPayment { get; set; }
   public double ShippingTax {get; set;}
   public double Tip { get; set; }

   public double Total {
    get { return BasicPayment + ShippingTax + Tip; }
   }
}
