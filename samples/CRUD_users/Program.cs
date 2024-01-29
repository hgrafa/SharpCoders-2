using CRUD_users.Entities;

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

  // single responsability principle

  public static void Main () {
    User victor = new User();

    User eu = new User{
      Id = int.Parse(Console.ReadLine()!),
      Email = Console.ReadLine()!,
      Username =  Console.ReadLine()!,
      Password = Console.ReadLine()!
    };

    // ImprimeUsuario(eu);

    Console.WriteLine(eu);
    Console.WriteLine(victor);

    // int option;

    // do {
    //   ShowMenu();
    //   option = int.Parse(Console.ReadLine());

    //   switch(option) {
    //   }
            
    // } while(option != 0);


  }

}


// Program.ImprimeUsuario(new User())