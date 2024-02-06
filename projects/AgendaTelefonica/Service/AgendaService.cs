using AgendaTelefonica.Model;
using NamespaceName;

namespace AgendaTelefonica.Service;

public class AgendaService
{
   public List<Contato> Contatos { get; set; } = new();
   public ContatoView ContatoView { get; set; } = new();

  public void AdicionarContato(Contato contato)
  {
      Contato contatoParaAdicionar = ContatoView.Novo();
      Contatos.Add(contato);
  }

}
