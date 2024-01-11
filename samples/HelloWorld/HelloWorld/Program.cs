// file-scoped namespace
namespace HelloWorld;

public class Program
{

    // funcao principal - ponto de entrada - entrypoint
    public static void Main()
    {
        // variaveis
        // casting - elenquei
        int a = 2;
        long l = 43;
        long x = 43l;

        float f = 2.3f;
        double d = 2;

        long inteiroLongo = 3L;
        int longo = (int)inteiroLongo;

        string name = "Hugo Rafael";

        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);

        Console.Write("Digite alguma coisa para ser lida: ");
        var leitura = Console.ReadLine();

        Console.WriteLine(leitura);

        var primeiroNumero = int.Parse(Console.ReadLine());
        var segundoNumero = Console.ReadLine();

        Console.WriteLine(primeiroNumero + segundoNumero);

        // selecao/condicionais
        // repeticao
        // funcoes
        // alguma alteracao

    }

}
