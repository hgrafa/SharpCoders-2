namespace IntroPOO;

public class Program
{
   public static void Main(string[] args)
   {
       
      Carro civic = new Carro();

      civic.placa = "XYZ123";
      civic.ano = 2021;

      Console.WriteLine(civic.combustivelEmLitros);

      civic.Abastecer(20);

      Console.WriteLine(civic.combustivelEmLitros);

   }
}
