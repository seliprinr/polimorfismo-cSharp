using polimorfismo_cSharp;

List<FormaGeometrica> formas = new List<FormaGeometrica>
    {
        new Circulo(),
        new Quadrado()
    };

foreach (FormaGeometrica forma in formas)
{
    forma.Desenhar();
}