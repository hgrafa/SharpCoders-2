namespace AgendaTelefonica.Model;

public class Telefone
{
   public string Ddd { get; set; }
   public string Numero { get; set; }

   public string NumeroCompleto {
      get {
         return $"({Ddd}) {Numero}";
      }
   }
}
