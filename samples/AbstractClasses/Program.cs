
// ok
using AbstractClasses.Model;
using NamespaceName;

Circulo c1 = new();
FormaGeometrica f1 = new Circulo();
IFormaGeometrica f2 = new Circulo();

f1.Area();

// nao ok
// FormaGeometrica f2 = new FormaGeometrica();
