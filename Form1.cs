using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsemir.formas;

namespace WindowsFormsemir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menupesos_Click(object sender, EventArgs e)
        {

        }

        private void áreadeltriángulo_Click(object sender, EventArgs e)
        {
            formaárea home = new formaárea();
            home.Show();
        }

        private void menupesosMexicanos_Click(object sender, EventArgs e)
        {
            Formapesos home = new Formapesos();
            home.Show();
        }

        private void menufrecuencia_Click(object sender, EventArgs e)
        {
            Formafrecuencia home = new Formafrecuencia();
            home.Show();
        }

        private void ecuaciónDeSegundoGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menufábrica_Click(object sender, EventArgs e)
        {
            Formafábrica home = new Formafábrica();
            home.Show();
        }

        private void menuecuación_Click(object sender, EventArgs e)
        {
            Formaecuación home = new Formaecuación();
            home.Show();
        }
    }
}
