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
    public partial class Formapesos : Form
    {
        public Formapesos()
        {
            InitializeComponent();
        }

        private void textLatidos_Click(object sender, EventArgs e)
        {

        }

        private void textEdad_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpesos_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxpesos.Text, out double pesos) || pesos < 0)
            {
                MessageBox.Show("Error: Ingrese un número positivo válido en pesos.");
                textBoxpesos.Text = ""; // Limpia el cuadro de texto en caso de error.
            }
        }

        private void buttondolares_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxpesos.Text, out double pesos) && pesos >= 0)
            {
                double resultado = pesos * 0.055 / 2;
                textBoxdolares.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Error: Ingrese un número positivo válido en pesos.");
            }
        }

        private void buttoeuros_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxpesos.Text, out double pesos) && pesos >= 0)
            {
                double resultado = pesos * 0.053 / 2;
                textBoxeuros.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Error: Ingrese un número positivo válido en pesos.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
