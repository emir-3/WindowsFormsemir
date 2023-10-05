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
    public partial class Formafrecuencia : Form
    {
        public Formafrecuencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonfrecuencia_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxedad.Text, out double edad) && edad >= 0)
            {
                double resultado = 220 - edad;
                textBoxfrecuencia.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Error: Ingrese un número positivo válido en edad.");
                textBoxedad.Text = ""; // Limpia el cuadro de texto en caso de error.
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonlatidos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxedad.Text, out double edad) && edad >= 0)
            {
                double frecuencia = 220 - edad;
                double resultado = (frecuencia - edad) / 2;
                textBoxlatido.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Error: Ingrese un número positivo válido en edad.");
                textBoxedad.Text = ""; // Limpia el cuadro de texto en caso de error.
            }
        }
    }
}
