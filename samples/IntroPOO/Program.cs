using IntroPOO.Model;

namespace IntroPOO; // espaco declarativo

public class Program
{
   public static void ImprimeMusica(Song musica) {
      Console.WriteLine($"Nome da Musica: {musica.nome}" );
      Console.WriteLine($"Artista: {musica.artista}" );
      Console.WriteLine($"Duracao: {musica.duracaoEmMinutos} min" );
      // nao consigo exibir pois eh privado (RUIM)
      Console.WriteLine($"Data de Criacao: {musica.DataDeCriacao}" );
      Console.WriteLine($"Ano de Lancamento: {musica.GetAnoDeLancamento()}");      
   }

   public static void Main(string[] args)
   {

      // Console.WriteLine(civic.ano);
      // Console.WriteLine(civic.dono ?? "sem dono");
      // Console.WriteLine(civic.placa ?? "sem placa");
      // Console.WriteLine(civic.combustivelEmLitros);
      // Console.WriteLine(civic.cor ?? "sem cor");
      // Console.WriteLine(civic.modelo ?? "sem modelo");

      Carro civic = new Carro();

      // construtor = melhorar a criacao de objetos
      Song musica1 = new Song("Locked out heaven", 3, "Bruno Mars", 2018, "2018-01-01");
      // musica1.nome = "Locked out heaven";
      // musica1.duracaoEmMinutos = 3;
      // musica1.artista = "Bruno Mars";

      Song musica2 = new Song("Ease", 4, "Adelle", 2022, "2021-01-01");

      // utilizacao dos nossos atributos

      // nao consigo editar a variavel privada (BOM)
      // musica1._dataDeCriacao = "abcabcabc";

      musica1.SetAnoDeLancamento(2015);
      musica2.SetAnoDeLancamento(-10);

      // musica1.DataDeCriacao = "asonas";

      ImprimeMusica(musica1);
      Console.WriteLine("------------------");
      ImprimeMusica(musica2);

      // civic.placa = "XYZ123";
      // civic.ano = 2021;

      // Console.WriteLine($"total em litros: {civic.combustivelEmLitros}");

      // civic.Abastecer(20);

      // Console.WriteLine($"total em litros: {civic.combustivelEmLitros}");

   }
}
