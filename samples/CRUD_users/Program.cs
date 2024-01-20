using System.Diagnostics;

namespace CRUD_users;

public class Program {

  static void ShowMenu() {
    Console.WriteLine("Escolha uma opcao abaixo");
    Console.WriteLine("1 - para criar um usuario");
    Console.WriteLine("2 - buscar um usuario");
    Console.WriteLine("3 - listar os usuarios (sem senha se houver)");
    Console.WriteLine("4 - atualizar um usuario");
    Console.WriteLine("5 - deletar um usuario");
    Console.WriteLine("0 - para sair");
    Console.Write("Digite a opcao desejada: ");
  }

  static void CriarUsuario(int emptyPosition, string[] usernames, string[] emails, string[] passwords) {
    Console.Write("Digite seu username: ");
    usernames[emptyPosition] = Console.ReadLine();

    Console.Write("Digite seu email: ");
    emails[emptyPosition] = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    passwords[emptyPosition] = Console.ReadLine();
  }

  public static void Main () {

    int TOTAL_SIZE = 1000, size = 0;

    string[] usernames = new string[TOTAL_SIZE];
    string[] emails = new string[TOTAL_SIZE];
    string[] passwords = new string[TOTAL_SIZE];

    // CriarUsuario(emptyPosition, usernames, emails, passwords);
    // size++;

    // 6 = 0, 1, 2, 3, 4, 5, _
    // CriarUsuario(size++, usernames, emails, passwords);

    // TODO: reutilizar isso quando for listar todos
    // for(int i = 0; i < size; i++) {
    //   Console.WriteLine("-----------------");
    //   Console.WriteLine(usernames[i]);
    //   Console.WriteLine(emails[i]);
    //   Console.WriteLine(passwords[i]);
    //   Console.WriteLine("-----------------");
    // }

    // Comparativo
    // while pra menu = mostrarMenu verifico&faço mostrarMenu ...
    // do...while = fazendo verifica fazendo

    // ShowMenu();
    // int option = int.Parse(Console.ReadLine());

    // while(option != 0) {

    //   switch(option) {
    //     case 1:
    //       CriarUsuario(size++, usernames, emails, passwords);
    //       break;
    //     default:
    //       Console.WriteLine("Digite uma opcao valida!");
    //       break;
    //   }

    //   ShowMenu();
    //   option = int.Parse(Console.ReadLine());
    // }

    int option;

    do {
      ShowMenu();
      option = int.Parse(Console.ReadLine());

      switch(option) {
        case 0:
          Console.WriteLine("valeu, ate a proxima!");
          break;
        case 1:
          CriarUsuario(size++, usernames, emails, passwords);
          break;
        default:
          Console.WriteLine("Digite uma opcao valida!");
          break;
      }
            
    } while(option != 0);
  }

}