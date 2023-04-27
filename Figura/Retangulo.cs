using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Retangulo : figura__Classe
    {
        double baseR;
        double altura;

        public Retangulo(double baseR, double altura) : base(baseR, altura)
        {
            this.baseR = baseR;
            this.altura = altura;
            MessageBox.Show("Retangulo criado");
        }

        public override double calculaArea()
        {
            return baseR * altura;
        }

    }
}
