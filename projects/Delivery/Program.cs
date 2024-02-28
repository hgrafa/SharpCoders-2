using Delivery.Domain.Model;
using Delivery.Infra.Service;


Product p1 = new Product() {
  Name = "Fetuccini",
  Price = 40,
};

Product p2 = new Product() {
  Name = "Lasanha",
  Price = 35,
};

Product p3 = new Product() {
  Name = "Carbonara",
  Price = 25,
};

Product p4 = new Product() {
  Name = "Risoto",
  Price = 55,
};

DeliveryService deliveryService = new();

deliveryService.CreateOrder(new Order() {
  Moment = DateTime.Now,
  Items = new List<OrderItem>() {
    new OrderItem() {
      Product = p1,
      Quantity = 2
    },
    new OrderItem() {
      Product = p3,
      Quantity = 4
    }
  }
});

deliveryService.Orders.ForEach((order) => Console.WriteLine(order));