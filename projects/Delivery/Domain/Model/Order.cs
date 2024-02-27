using Delivery.Domain.Enum;

namespace Delivery.Domain.Model;

public class Order
{
  public OrderStatus Status { get; set; } = OrderStatus.WAITING_PAYMENT;
  public DateTime Moment { get; set; }
  public Restaurant Restaurant { get; set; }
  public List<OrderItem> Items { get; set; } = new();
}