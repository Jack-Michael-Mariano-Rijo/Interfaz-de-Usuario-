namespace Tarea_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCarcular_Click(object sender, EventArgs e)
        {
            double Sumar,Promedio,Numero1,Numero2,Numero3,Numero4;
            Numero1 = Convert.ToDouble(textBox1.Text);
            Numero2 = Convert.ToDouble(textBox2.Text);
            Numero3 = Convert.ToDouble(textBox3.Text);
            Numero4 = Convert.ToDouble(textBox4.Text);

            Sumar = Numero1 + Numero2 + Numero3 + Numero4;
            Promedio = Sumar / 4;

           MessageBox.Show("La suma es: " + Sumar + "\nEl promedio es: " + Promedio);
        }
    }
}
