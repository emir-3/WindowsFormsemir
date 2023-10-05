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
    public partial class Formaecuación : Form
    {
        public Formaecuación()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttoncalculars_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double valorA) &&
                double.TryParse(textBoxB.Text, out double valorB) &&
                double.TryParse(textBoxC.Text, out double valorC))
            {
                if (valorA == 0)
                {
                    MessageBox.Show("El coeficiente 'a' no puede ser igual a cero.");
                    return;
                }

                double discriminante = valorB * valorB - 4 * valorA * valorC;

                if (discriminante < 0)
                {
                    MessageBox.Show("El discriminante es negativo, las raíces son complejas.");
                }
                else
                {
                    double raiz1 = (-valorB + Math.Sqrt(discriminante)) / (2 * valorA);
                    double raiz2 = (-valorB - Math.Sqrt(discriminante)) / (2 * valorA);

                    MessageBox.Show($"Las raíces reales son:\nRaíz 1: {raiz1}\nRaíz 2: {raiz2}");
                }
            }
            else
            {
                MessageBox.Show("Error: Datos incorrectos. Asegúrese de ingresar números válidos.");
            }
        }
    }
}