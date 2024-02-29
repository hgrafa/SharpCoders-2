using Heranca.Enums;

namespace Heranca.Model;

public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(Cor cor, double raio) 
    : base(cor)
    {
      Raio = raio;
    }
}
