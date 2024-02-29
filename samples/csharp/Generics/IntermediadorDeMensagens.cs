namespace Generics;

public class IntermediadorDeMensagens<T> {

  public List<T> Mensagens {get; private set;} = new();

  public void Acumular(T valor) {
    Mensagens.Add(valor);
  }

  public void Disparar() {
    foreach(T mensagem in Mensagens) {
      int currentPositionToRemove = 0;
      Console.WriteLine(mensagem);
      Mensagens.RemoveAt(currentPositionToRemove);
    }
  }

}