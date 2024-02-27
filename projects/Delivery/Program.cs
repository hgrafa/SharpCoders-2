using Delivery.Domain.Model;
using Delivery.Infra.Service;

Restaurant spoletoRestaurant = new Restaurant() { Name = "Spoleto" };

Product p1 = new Product() {
  Name = "Fetuccini",
  Price = 40,
  Restaurant = spoletoRestaurant
};

Product p2 = new Product() {
  Name = "Lasanha",
  Price = 35,
  Restaurant = spoletoRestaurant
};

Product p3 = new Product() {
  Name = "Carbonara",
  Price = 25,
  Restaurant = spoletoRestaurant
};

Product p4 = new Product() {
  Name = "Risoto",
  Price = 55,
  Restaurant = spoletoRestaurant
};

DeliveryService deliveryService = new();

deliveryService.CreateOrder(new Order() {
  Moment = DateTime.Now,
  Restaurant = spoletoRestaurant,
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