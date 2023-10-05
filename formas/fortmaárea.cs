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
    public partial class formaárea : Form
    {
        public formaárea()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            float baseT, alturaT;

            if (float.TryParse(textBoxbase.Text, out baseT) && float.TryParse(textBoxaltura.Text, out alturaT) && baseT >= 0 && alturaT >= 0)
            {
                MessageBox.Show("El área del triángulo es " + (baseT * alturaT / 2));
            }
            else
            {
                MessageBox.Show("Error: Ingrese números positivos válidos en la base y la altura.");
            }
        }

        private void buttoncaalcular_Click(object sender, EventArgs e)
        {

        }

        private void textBoxarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxbase_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxbase.Text, out float baseT) || baseT < 0)
            {
                MessageBox.Show("Error: Ingrese un número positivo válido en la base.");
                textBoxbase.Text = ""; // Limpia el cuadro de texto en caso de error.
            }
        }

        private void textBoxaltura_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxaltura.Text, out float alturaT) || alturaT < 0)
            {
                MessageBox.Show("Error: Ingrese un número positivo válido en la altura.");
                textBoxaltura.Text = ""; // Limpia el cuadro de texto en caso de error.
            }
        }
    }
}
