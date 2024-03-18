namespace MuitosPraMuitosRelacionamento.Infra.Repository;

// dao = data access object
public interface IRepository<TEntity>
{
   
  Task<IEnumerable<TEntity>> FindAll();
  Task<TEntity?> FindById(int ID);
  Task Save(TEntity entity);
  Task<TEntity> Update(int id, TEntity newEntity);
  Task<bool> DeleteById(int id);

}
