using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsemir.formas
{
    public partial class Formafábrica : Form
    {
        public Formafábrica()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttoncalcularr_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxsalario.Text, out double salarioactual) && salarioactual >= 0 &&
                double.TryParse(textBoxaumento.Text, out double aumento) && aumento >= 0)
            {
                double salarioNew = salarioactual / 100 * aumento;
                double salarioNuevo = salarioNew + salarioactual;
                textBoxresultado.Text = salarioNuevo.ToString();
            }
            else
            {
                MessageBox.Show("Error: Ingrese números positivos válidos en salario y aumento.");
                textBoxsalario.Text = ""; // Limpia el cuadro de texto en caso de error.
                textBoxaumento.Text = ""; // Limpia el cuadro de texto en caso de error.
            }
        }
    }
}