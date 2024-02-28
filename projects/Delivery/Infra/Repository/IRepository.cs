namespace Delivery.Infra.Repository;

public interface IRepository<T> {

  List<T> GetAll();
  T? GetById(int id);
  void Save(T data);

}