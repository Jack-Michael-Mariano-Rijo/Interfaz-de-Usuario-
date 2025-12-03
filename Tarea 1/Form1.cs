namespace Tarea_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCarcular_Click(object sender, EventArgs e)
        {
            double Suma,Resta, Multiplicacion, Division;
            double numero1 = Convert.ToDouble(textBoxNumero1.Text);
            double numero2 = Convert.ToDouble(textBoxNumero2.Text);

            Suma = numero1 + numero2;
            Resta = numero1 - numero2;
            Multiplicacion = numero1 * numero2;
            Division = numero1 / numero2;

            labelSuma.Text = Suma.ToString();
            labelResta.Text = Resta.ToString();
            labelMultiplicacion.Text = Multiplicacion.ToString();
            labelDivision.Text = Division.ToString();

        }
    }
}
