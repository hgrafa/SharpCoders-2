using Delivery.Domain.Model;

namespace Delivery.Infra.Service;

public class DeliveryService
{
  public List<Order> Orders { get; private set; } = new();

  public void CreateOrder(Order order) {

    bool hasItemsFromDiferentRestaurants = order.Items
    .Any((item) => item.Product.Restaurant != order.Restaurant);

    if(hasItemsFromDiferentRestaurants) {
      return;
    }

    Orders.Add(order);
  }

  public void ProcessInvoice(Order order) {

  }
}
