using AgendaTelefonica.Model;

namespace NamespaceName;

public class ContatoView
{
   public Contato Novo() {
    Console.Write("Digite o nome do contato:");
    string nome = Console.ReadLine();
    Console.Write("Digite o sobrenome do contato:");
    string sobrenome = Console.ReadLine();
    return new Contato() {Nome = nome, Sobrenome = sobrenome};
   }
}
