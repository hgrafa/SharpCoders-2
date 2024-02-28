using Delivery.Domain.Model;

namespace Delivery.Infra.Repository;

public class OrderRepository : IRepository<Order>
{
    public List<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Save(Order data)
    {
        throw new NotImplementedException();
    }
}
