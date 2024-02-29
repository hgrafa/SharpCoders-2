namespace Generics;

public class Crud<T> {

  public List<T> values = new();

  public void Add(T value) {
    values.Add(value);
  }

  public void Remove(T value) {
    values.Remove(value);
  }

  public void Update(int index, T value) {
    bool valueIsInList = values.Contains(value);

    if( !valueIsInList )
      return;

    values[index] = value;
  }

  public void Delete(T value) {
    values.Remove(value);
  }


}