using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IngEconomicaAPP
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Entrada entrada = new Entrada();
            MostrarFormulario(entrada);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }
        public void MostrarFormulario(Form formulario)
        {
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            this.panel3.Controls.Add(formulario);
            formulario.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AbrirFormHijo(object Formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(new Informacion());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(new InteresSimple());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new InteresCompuesto());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Anualidades());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Amortizacion());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Formulas());
        }
    }
}
