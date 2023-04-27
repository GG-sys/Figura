using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class figura__Classe
    {
        double area;
        double perimetro;

        public figura__Classe(double area, double perimetro)
        {
            this.area = area;
            this.perimetro = perimetro;
            Console.WriteLine("Figura Criada");
        }

        public virtual double calculaArea()
        {
            return 0;
        }
    }
}
