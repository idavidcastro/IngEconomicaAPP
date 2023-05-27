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
    public partial class InteresCompuesto : Form
    {
        public InteresCompuesto()
        {
            InitializeComponent();
        }
        private void LimpiarCampos2()
        {
            txtVP2.Text = "";
            txtVF2.Text = "";
            txtTI2.Text = "";
            txtNPeriodos2.Text = "";
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


                vp = vf / Math.Pow((1 + i), n);
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


                vf = vp * Math.Pow((1 + i), n);
                Math.Truncate(vf);
                txtVF2.Text = vf.ToString();
            }
            if (cmbIS2.SelectedItem.Equals("Tasa de interés"))
            {
                vf = double.Parse(txtVF2.Text);
                vp = double.Parse(txtVP2.Text);
                n = double.Parse(txtNPeriodos2.Text);
                n = (n * vlr2) / vlr;


                i = Math.Pow((vf / vp), 1 / n) - 1;
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

                n = Math.Log(arg1) / Math.Log(arg2);
                Math.Truncate(n);
                txtNPeriodos2.Text = n.ToString();


            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarCampos2();
        }

        private void cmbIS2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

