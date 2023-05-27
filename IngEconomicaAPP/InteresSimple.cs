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
    public partial class InteresSimple : Form
    {
        public InteresSimple()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
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

            if (cmbTI.SelectedIndex == 0)
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



                vp = vf / (1 + i * n);
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

                i = 1 / n * ((vf / vp) - 1);
                i = i * 100;
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
        private void cmbIS_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

