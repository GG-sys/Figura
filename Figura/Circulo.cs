using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Circulo : figura__Classe
    {
        public double raio;

        public Circulo(double raio) : base(raio * 2, raio * 2)
        {
            this.raio = raio;
            MessageBox.Show("Círculo criado");
        }

        public override double calculaArea()
        {
            return (3.14 * (Math.Pow(raio, 2)));
        }
    }
}
