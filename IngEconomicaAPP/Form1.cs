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
            if (txtVP.Text == "")
                MessageBox.Show("EXISTEN CAMPOS VACIOS");
            else if (txtVF.Text == "")
                MessageBox.Show("EXISTEN CAMPOS VACIOS");
            else if (txtTI.Text == "")
                MessageBox.Show("EXISTEN CAMPOS  VACIOS");
            else if (txtNPeriodos.Text == "")
                MessageBox.Show("");
           



            //VP = VF / [(1 + i) ^ n]
            double vf, vp, i, n;
            int vlr, vlr2;

            if (cmbTI.SelectedIndex==0)
            {
                vlr = 1;
            }
            else if (cmbTI.SelectedIndex == 1)
            {
                vlr = 2;
            }
            else if (cmbTI.SelectedIndex == 2)
            {
                vlr = 3;
            }
            else if (cmbTI.SelectedIndex == 3)
            {
                vlr = 6;
            }
            else
            {
                vlr = 12;
            }

            ////////////////////////////////////////////////////////
            
            if (cmbPeriodos.SelectedIndex == 0)
            {
                vlr2 = 1;
            }
            else if (cmbPeriodos.SelectedIndex == 1)
            {
                vlr2 = 2;
            }
            else if (cmbPeriodos.SelectedIndex == 2)
            {
                vlr2 = 3;
            }
            else if (cmbPeriodos.SelectedIndex == 3)
            {
                vlr2 = 6;
            }
            else
            {
                vlr2 = 12;
            }

            //////////////////////////////////////////////

            if (cmbIS.SelectedItem.Equals("Valor presente"))
            {
                //double elevador;
                vf = double.Parse(txtVF.Text);
                i = double.Parse(txtTI.Text);
                i = i / 100;

                n = double.Parse(txtNPeriodos.Text);

                n = (n * vlr2) / vlr;

               
                
                vp = vf / (1+i*n);
                Math.Truncate(vp);
                txtVP.Text = vp.ToString();
            }

            if (cmbIS.SelectedItem.Equals("Valor futuro"))
            {
                vp = double.Parse(txtVP.Text);
                i = double.Parse(txtTI.Text);
                i = i / 100;
                n = double.Parse(txtNPeriodos.Text);
                n = (n * vlr2) / vlr;

                vf = vp * (1 + i * n);
                Math.Truncate(vf);
                txtVF.Text = vf.ToString();
            }
            if (cmbIS.SelectedItem.Equals("Tasa de interés"))
            {
                vf = double.Parse(txtVF.Text);
                vp = double.Parse(txtVP.Text);
                n = double.Parse(txtNPeriodos.Text);
                n = (n * vlr2) / vlr;

                i = 1 / n *((vf / vp) - 1);
                i = i*100;
                txtTI.Text = i.ToString();
            }
            if (cmbIS.SelectedItem.Equals("Número de periodos"))
            {
                vf = double.Parse(txtVF.Text);
                vp = double.Parse(txtVP.Text);
                i = double.Parse(txtTI.Text);
                i = i / 100;

                n = 1 / i * ((vf / vp) - 1);
                Math.Truncate(n);
                txtNPeriodos.Text = n.ToString();

            }
        }

        private void LimpiarCampos()
        {
            txtVP.Text = "";
            txtVF.Text = "";
            txtTI.Text = "";
            txtNPeriodos.Text = "";
        }
        private void LimpiarCampos2()
        {
            txtVP2.Text = "";
            txtVF2.Text = "";
            txtTI2.Text = "";
            txtNPeriodos2.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbIS2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbIS2.SelectedItem.Equals("Valor presente"))
            {
                txtVP2.Enabled = false;
                txtVF2.Enabled = true;
                txtTI2.Enabled = true;
                txtNPeriodos2.Enabled = true;
                LimpiarCampos2();
            }
            if (cmbIS2.SelectedItem.Equals("Valor futuro"))
            {
                txtVP2.Enabled = true;
                txtVF2.Enabled = false;
                txtTI2.Enabled = true;
                txtNPeriodos2.Enabled = true;
                LimpiarCampos2();
            }
            if (cmbIS2.SelectedItem.Equals("Tasa de interés"))
            {
                txtVP2.Enabled = true;
                txtVF2.Enabled = true;
                txtTI2.Enabled = false;
                txtNPeriodos2.Enabled = true;
                LimpiarCampos2();
            }
            if (cmbIS2.SelectedItem.Equals("Número de periodos"))
            {
                txtVP2.Enabled = true;
                txtVF2.Enabled = true;
                txtTI2.Enabled = true;
                txtNPeriodos2.Enabled = false;
                LimpiarCampos2();
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarCampos2();
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double vf, vp, i, n;
            int vlr, vlr2;

            if (cmbTI2.SelectedIndex == 0)
            {
                vlr = 1;
            }
            else if (cmbTI2.SelectedIndex == 1)
            {
                vlr = 2;
            }
            else if (cmbTI2.SelectedIndex == 2)
            {
                vlr = 3;
            }
            else if (cmbTI2.SelectedIndex == 3)
            {
                vlr = 6;
            }
            else
            {
                vlr = 12;
            }

            ////////////////////////////////////////////////////////

            if (cmbPeriodos2.SelectedIndex == 0)
            {
                vlr2 = 1;
            }
            else if (cmbPeriodos2.SelectedIndex == 1)
            {
                vlr2 = 2;
            }
            else if (cmbPeriodos2.SelectedIndex == 2)
            {
                vlr2 = 3;
            }
            else if (cmbPeriodos2.SelectedIndex == 3)
            {
                vlr2 = 6;
            }
            else
            {
                vlr2 = 12;
            }

            //////////////////////////////////////////////



            if (cmbIS2.SelectedItem.Equals("Valor presente"))
            {
                //double elevador;
                vf = double.Parse(txtVF2.Text);
                i = double.Parse(txtTI2.Text);
                i = i / 100;
                n = double.Parse(txtNPeriodos2.Text);
                n = (n * vlr2) / vlr;

                MessageBox.Show(n.ToString());


                vp = vf / Math.Pow((1 + i),n);
                Math.Truncate(vp);
                txtVP2.Text = vp.ToString();
            }

            if (cmbIS2.SelectedItem.Equals("Valor futuro"))
            {
                vp = double.Parse(txtVP2.Text);
               
                i = double.Parse(txtTI2.Text);
                i = i / 100;
                n = double.Parse(txtNPeriodos2.Text);
                n = (n * vlr2) / vlr;


                vf = vp * Math.Pow((1 + i),n);
                Math.Truncate(vf);
                txtVF2.Text = vf.ToString();
            }
            if (cmbIS2.SelectedItem.Equals("Tasa de interés"))
            {
                vf = double.Parse(txtVF2.Text);
                vp = double.Parse(txtVP2.Text);
                n = double.Parse(txtNPeriodos2.Text);
                n = (n * vlr2) / vlr;


                i = Math.Pow((vf/vp),1/n) -1;
                i = i * 100;

                txtTI2.Text = i.ToString();
            }
            if (cmbIS2.SelectedItem.Equals("Número de periodos"))
            {
                vf = double.Parse(txtVF2.Text);
                vp = double.Parse(txtVP2.Text);
                i = double.Parse(txtTI2.Text);
                i = i / 100;

                double arg1, arg2;
                arg1 = vf / vp;
                arg2 = 1 + i;

                n = Math.Log(arg1)/Math.Log(arg2);
                Math.Truncate(n);
                txtNPeriodos2.Text = n.ToString();


            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtVP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void numerico(object sender, CancelEventArgs e)
        {

        }
    }
}
