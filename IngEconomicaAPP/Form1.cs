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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbIS_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbIS.SelectedItem.Equals("Valor presente"))
            {
                txtVP.Enabled = false;
                txtVF.Enabled = true;
                txtTI.Enabled = true;
                txtNPeriodos.Enabled = true;
                LimpiarCampos();
            }
            if (cmbIS.SelectedItem.Equals("Valor futuro"))
            {
                txtVP.Enabled = true;
                txtVF.Enabled = false;
                txtTI.Enabled = true;
                txtNPeriodos.Enabled = true;
                LimpiarCampos();
            }
            if (cmbIS.SelectedItem.Equals("Tasa de interés"))
            {
                txtVP.Enabled = true;
                txtVF.Enabled = true;
                txtTI.Enabled = false;
                txtNPeriodos.Enabled = true;
                LimpiarCampos();
            }
            if (cmbIS.SelectedItem.Equals("Número de periodos"))
            {
                txtVP.Enabled = true;
                txtVF.Enabled = true;
                txtTI.Enabled = true;
                txtNPeriodos.Enabled = false;
                LimpiarCampos();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VP = VF / [(1 + i) ^ n]
            double vf, vp, i, n;
            


            if (cmbIS.SelectedItem.Equals("Valor presente"))
            {
                //double elevador;
                vf = double.Parse(txtVF.Text);
                i = double.Parse(txtTI.Text);
                i = i / 100;
                n = double.Parse(txtNPeriodos.Text);

                
                vp = vf / (1+i*n);
                txtVP.Text = vp.ToString();
            }

            if (cmbIS.SelectedItem.Equals("Valor futuro"))
            {
                vp = double.Parse(txtVP.Text);
                i = double.Parse(txtTI.Text);
                i = i / 100;
                n = double.Parse(txtNPeriodos.Text);


                vf = vp * (1 + i * n);
                txtVF.Text = vf.ToString();
            }
            if (cmbIS.SelectedItem.Equals("Tasa de interés"))
            {
                vf = double.Parse(txtVF.Text);
                vp = double.Parse(txtVP.Text);
                n = double.Parse(txtNPeriodos.Text);



            }
            if (cmbIS.SelectedItem.Equals("Número de periodos"))
            {
                vf = double.Parse(txtVF.Text);
                vp = double.Parse(txtVP.Text);
                i = double.Parse(txtTI.Text);
                i = i / 100;


            }
        }

        private void LimpiarCampos()
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txtTI.Text = "";
            txtNPeriodos.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
