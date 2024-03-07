using DatabaseSqlite.Domain.Model;

namespace DatabaseSqlite.Domain.Model;

public class Endereco : Entity
{

  public string Rua { get; set; }
  public string Cep { get; set; }
  public string Estado { get; set; }
  public string Cidade { get; set; }

}
