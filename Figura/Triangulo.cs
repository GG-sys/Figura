using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Triangulo : figura__Classe
    {
        double baseT;
        double altura;

        public Triangulo(double baseT, double altura) : base(baseT, altura)
        {
            this.baseT = baseT;
            this.altura = altura;
            MessageBox.Show("Triângulo criado");
        }

        public override double calculaArea()
        {
            return (baseT * altura) / 2;
        }
    }
}
