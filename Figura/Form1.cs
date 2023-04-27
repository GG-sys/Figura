namespace Figura
{
    public partial class Form1 : Form
    {
        Circulo circulo1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raioX;

            raioX = Convert.ToDouble(inputRaio.Text);
            if (circulo1 == null)
            {
                circulo1 = new Circulo(raioX);
            } else
            {
                circulo1.raio = raioX;
            }

            label4.Text = Convert.ToString((circulo1.calculaArea()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double baseR;
            double altura;

            baseR = Convert.ToDouble(inputBase.Text);
            altura = Convert.ToDouble(inputAltura.Text);

            Retangulo retangulo1 = new Retangulo(baseR, altura);

            label5.Text = Convert.ToString(retangulo1.calculaArea());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double baseT;
            double altura;

            baseT = Convert.ToDouble(inputBaseT.Text);
            altura = Convert.ToDouble(inputAlturaT.Text);

            Triangulo triangulo1 = new Triangulo(baseT, altura);

            label11.Text = Convert.ToString(triangulo1.calculaArea());

        }
    }
}