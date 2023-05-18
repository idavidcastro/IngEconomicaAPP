using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngEconomicaAPP
{
    public partial class Bienvenida1 : Form
    {
        public Bienvenida1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.ShowDialog();
            Form formulario = new Principal();
            formulario.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
            
                this.Close();
            }
        }
    }
}
