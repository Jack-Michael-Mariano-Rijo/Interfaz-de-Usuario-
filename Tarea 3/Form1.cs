namespace Tarea_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pagoHora = Convert.ToDouble(textBoxPagoporhora.Text);
            double horasTrabajadas = Convert.ToDouble(textBoxHoratrabajadas.Text);

            double salarioBruto = pagoHora * horasTrabajadas;

            double afp = salarioBruto * 0.0287;
            double sfs = salarioBruto * 0.0304;
            double Neto = salarioBruto - (afp + sfs + 700);
            double desc700 = 700;

            double totalDesc = afp + sfs + desc700;

            labelAFP.Text = afp.ToString("C2");
            labelSFS.Text = sfs.ToString("C2");
            labelBruto.Text = salarioBruto.ToString("C2");
            labelNeto.Text = Neto.ToString("C2");
            labelTotalDesc.Text = totalDesc.ToString("C2");
            labelDesc.Text = desc700.ToString("C2");
        }


        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPagoporhora.Clear();
            textBoxHoratrabajadas.Clear();

            labelAFP.Text = "AFP";
            labelSFS.Text = "SFS";
            labelDesc.Text = "Desc";
            labelBruto.Text = "Bruto";
            labelTotalDesc.Text = "TotalDesc";
            labelNeto.Text = "Neto";  
        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
