using System.Diagnostics;

namespace CRUD_users;

public class Program {

  static void ShowMenu() {
    Console.WriteLine("Escolha uma opcao abaixo");
    // 1 - para criar um usuario
    // 2 - buscar um usuario
    // 3 - listar os usuarios (sem senha se houver)
    // 4 - atualizar um usuario
    // 5 - deletar um usuario
    // 0 - para sair
    Console.Write("Digite a opcao desejada: ");
  }

  static void CriarUsuario() {
    Console.WriteLine("Usuario Criado");
  }

  public static void Main () {

    int size = 1000;
    string[] usernames = new string[size];
    string[] emails = new string[size];
    string[] passwords = new string[size];

    ShowMenu();
    int option = int.Parse(Console.ReadLine());

    while(option != 0) {

      if(option == 1) {
        CriarUsuario();
      }

      ShowMenu();
      option = int.Parse(Console.ReadLine());
    }
  }

}