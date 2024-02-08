
using Heranca.Enums;

namespace Heranca.Model;

public class FormaGeometrica
{
  public double Espessura { get; set; }
  public Cor Cor { get; set; }

  public FormaGeometrica(Cor cor)
  {
    Cor = cor;
  }
}