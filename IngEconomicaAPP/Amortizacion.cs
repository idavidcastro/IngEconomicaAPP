using System;
using System.Windows.Forms;

namespace IngEconomicaAPP
{
    public partial class Amortizacion : Form
    {
        public Amortizacion()
        {
            InitializeComponent();
            txtVPT.Text = 0.ToString();
            txtVFT.Text = 0.ToString();
            cmbPeriodosT.SelectedIndex = 0;
            cmbTIT.SelectedIndex = 0;
            cmbVST.SelectedIndex = 0;
            txtRentaT.Enabled = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularT_Click(object sender, EventArgs e)
        {
            
            if (txtVPT.Text == "" || txtVFT.Text == "" || txtTIT.Text == "" || txtNPeriodosT.Text == "")
            {
                MessageBox.Show("EXISTEN CAMPOS  VACÍOS");
            }
            else
            {
                double vf = 0, va = 0, i = 0, n = 0, r = 0;
                int vlr, vlr2;

                if (cmbTIT.SelectedIndex == 0)
                {
                    vlr = 1;
                }
                else if (cmbTIT.SelectedIndex == 1)
                {
                    vlr = 2;
                }
                else if (cmbTIT.SelectedIndex == 2)
                {
                    vlr = 3;
                }
                else if (cmbTIT.SelectedIndex == 3)
                {
                    vlr = 6;
                }
                else
                {
                    vlr = 12;
                }

                ////////////////////////////////////////////////////////

                if (cmbPeriodosT.SelectedIndex == 0)
                {
                    vlr2 = 1;
                }
                else if (cmbPeriodosT.SelectedIndex == 1)
                {
                    vlr2 = 2;
                }
                else if (cmbPeriodosT.SelectedIndex == 2)
                {
                    vlr2 = 3;
                }
                else if (cmbPeriodosT.SelectedIndex == 3)
                {
                    vlr2 = 6;
                }
                else
                {
                    vlr2 = 12;
                }

                if (cmbVST.SelectedItem.Equals("Renta"))
                {
                    va = double.Parse(txtVPT.Text);
                    vf = double.Parse(txtVFT.Text);
                    if (va != 0)
                    {
                        //vf = double.Parse(txtVf.Text);
                        //va = double.Parse(txtVA.Text);
                        n = double.Parse(txtNPeriodosT.Text);
                        n = (n * vlr2) / vlr;
                        i = double.Parse(txtTIT.Text);
                        i = i / 100;

                        r = (va * i) / (1 - Math.Pow((1 + i), -n));
                        Math.Truncate(r);
                        txtRentaT.Text = r.ToString("0.00");
                    }
                    else
                    {
                        //vf = double.Parse(txtVf.Text);
                        //va = double.Parse(txtVA.Text);
                        n = double.Parse(txtNPeriodosT.Text);
                        n = (n * vlr2) / vlr;
                        i = double.Parse(txtTIT.Text);
                        i = i / 100;

                        r = (vf * i) / (Math.Pow((1 + i), n) - 1);
                        Math.Truncate(r);
                        txtRentaT.Text = r.ToString("0.00");
                    }
                }
            }
        }
        private void LimpiarCampos()
        {
            txtVPT.Text = "";
            txtVFT.Text = "";
            txtTIT.Text = "";
            txtNPeriodosT.Text = "";
            txtRentaT.Text = "";
        }
        private void txtVFT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtVPT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVFT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTIT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNPeriodosT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVPT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtVFT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtTIT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtNPeriodosT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }
    }
}
