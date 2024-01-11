namespace Outputs;

public class Program
{
    public static void Main()
    {
        int a = 10;
        string nome = "Hugo";
        string sobrenome = "de Lima";

        Console.WriteLine($"valor da variavel a = {a}");
        Console.WriteLine($"nome: {nome.ToUpper()} {sobrenome}");

        int statusCode = 201;
        string message = "created";

        string response = $"ResponseMessage: {message}, status: {statusCode}";

        Console.WriteLine(response);

        string texto = "texto";
        int numero = 90;
        double preco = 40.95912;

        //int antesDaVirgula = (int) Math.Floor(preco);
        //preco = preco - antesDaVirgula; // 0.95912
        //preco = preco * 100; // 95.912
        //int depoisDaVirgula = (int)Math.Floor(preco);

        Console.WriteLine($"Valor final: R${preco:F2}"); // #001

        // interpolacao por referencia
        // Console.WriteLine("outputs: {0}, {1} e {2}", texto, numero, preco);
    }
}