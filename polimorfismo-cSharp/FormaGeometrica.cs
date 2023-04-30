using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_cSharp
{
    public class FormaGeometrica
    {
        public virtual void Desenhar()
        {

        }
    }

    public class Circulo : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um círculo!");
        }
    }

    public class Quadrado : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um quadrado!");
        }
    }
}
