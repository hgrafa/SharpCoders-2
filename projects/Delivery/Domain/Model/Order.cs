using Delivery.Domain.Enum;

namespace Delivery.Domain.Model;

public class Order
{
  public DateTime Moment { get; set; }
  public double DistanceInKm { get; set; }
  public OrderStatus Status { get; set; } = OrderStatus.WAITING_PAYMENT;
  public Invoice Invoice;
  public List<OrderItem> Items { get; set; } = new();

}