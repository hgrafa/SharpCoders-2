using Heranca.Enums;
using Heranca.Model;

Circulo c1 = new(Cor.VERMELHO, 10.0);

// upcasting - mencionar uma classe filha como sua classe mae
// sempre seguro
FormaGeometrica forma1 = new Circulo(Cor.AZUL, 5.0);

// downcasting - mencionar uma classe mae como sua classe filha
// nem sempre eh seguro e nao da erro enquanto escreve
Circulo circulo2 = (Circulo)forma1;

List<FormaGeometrica> formasGeometricas = new() {
  new Retangulo(Cor.PRETO),
  new Circulo(Cor.AZUL, 10.0)
};

void FazAlgo(FormaGeometrica formaGeometrica) {

}