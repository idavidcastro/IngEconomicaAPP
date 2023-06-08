using System;
using System.Windows.Forms;

namespace IngEconomicaAPP
{
    public partial class InteresCompuesto : Form
    {
        public InteresCompuesto()
        {
            InitializeComponent();
            cmbIS2.SelectedIndex = 0;
            cmbTI2.SelectedIndex = 0;
            cmbPeriodos2.SelectedIndex = 0;
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
            if (txtVP2.Text == "" || txtVF2.Text == "" || txtTI2.Text == "" || txtNPeriodos2.Text == "")
            {
                MessageBox.Show("EXISTEN CAMPOS  VACIOS");
            }
            else
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


                    vp = vf / Math.Pow((1 + i), n);
                    Math.Truncate(vp);
                    txtVP2.Text = vp.ToString("0.00");
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
                    txtVF2.Text = vf.ToString("0.00");
                }
                if (cmbIS2.SelectedItem.Equals("Tasa de interés"))
                {
                    vf = double.Parse(txtVF2.Text);
                    vp = double.Parse(txtVP2.Text);
                    n = double.Parse(txtNPeriodos2.Text);
                    n = (n * vlr2) / vlr;


                    i = Math.Pow((vf / vp), 1 / n) - 1;
                    i = i * 100;

                    txtTI2.Text = i.ToString("0.00");
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
                    txtNPeriodos2.Text = n.ToString("0.00");
                }
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarCampos2();
        }

        private void cmbIS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIS2.SelectedItem.Equals("Valor presente"))
            {
                txtVP2.Enabled = false;
                txtVP2.Text = 0.ToString();
                txtVF2.Enabled = true;
                txtVF2.Text = "";
                txtTI2.Enabled = true;
                txtTI2.Text = "";
                txtNPeriodos2.Enabled = true;
                txtNPeriodos2.Text = "";

            }
            if (cmbIS2.SelectedItem.Equals("Valor futuro"))
            {
                txtVP2.Enabled = true;
                txtVP2.Text = "";
                txtVF2.Enabled = false;
                txtVF2.Text = 0.ToString();
                txtTI2.Enabled = true;
                txtTI2.Text = "";
                txtNPeriodos2.Enabled = true;
                txtNPeriodos2.Text = "";
            }
            if (cmbIS2.SelectedItem.Equals("Tasa de interés"))
            {
                txtVP2.Enabled = true;
                txtVP2.Text = "";
                txtVF2.Enabled = true;
                txtVF2.Text = "";
                txtTI2.Enabled = false;
                txtTI2.Text = 0.ToString();
                txtNPeriodos2.Enabled = true;
                txtNPeriodos2.Text = "";

            }
            if (cmbIS2.SelectedItem.Equals("Número de periodos"))
            {
                txtVP2.Enabled = true;
                txtVP2.Text = "";
                txtVF2.Enabled = true;
                txtVF2.Text = "";
                txtTI2.Enabled = true;
                txtTI2.Text = "";
                txtNPeriodos2.Enabled = false;
                txtNPeriodos2.Text = 0.ToString();
            }
        }

        private void txtVP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Ignorar el punto si ya existe uno en el texto
            }
        }

        private void txtVF2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Ignorar el punto si ya existe uno en el texto
            }
        }

        private void txtTI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Ignorar el punto si ya existe uno en el texto
            }
        }

        private void txtNPeriodos2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true; // Ignorar el punto si ya existe uno en el texto
            }
        }

        private void txtVP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtVF2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtTI2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtNPeriodos2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }
    }
}

