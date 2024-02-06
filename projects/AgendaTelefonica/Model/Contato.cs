namespace AgendaTelefonica.Model;

public class Contato
{
   public string Nome { get; set; }
   public string Sobrenome { get; set; }
   public List<Telefone> Telefones { get; set; } = new();
   public List<Endereco> Enderecos { get; set; } = new();
}
