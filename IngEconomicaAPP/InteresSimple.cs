using System;
using System.Windows.Forms;

namespace IngEconomicaAPP
{
    public partial class InteresSimple : Form
    {
        public InteresSimple()
        {
            InitializeComponent();
            cmbIS.SelectedIndex = 0;
            cmbTI.SelectedIndex = 0;
            cmbPeriodos.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //if (txtVP.Text == "")
            //    MessageBox.Show("EXISTEN CAMPOS VACIOS");
            //else if (txtVF.Text == "")
            //    MessageBox.Show("EXISTEN CAMPOS VACIOS");
            //else if (txtTI.Text == "")
            //    MessageBox.Show("EXISTEN CAMPOS  VACIOS");
            //else if (txtNPeriodos.Text == "")
            //    MessageBox.Show("");

            if (txtVP.Text == "" || txtVF.Text == "" || txtTI.Text == "" || txtNPeriodos.Text == "")
            {
                MessageBox.Show("EXISTEN CAMPOS  VACIOS");
            }
            else
            {

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
                    txtVP.Text = vp.ToString("0.00");
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
                    txtVF.Text = vf.ToString("0.00");
                }
                if (cmbIS.SelectedItem.Equals("Tasa de interés"))
                {
                    vf = double.Parse(txtVF.Text);
                    vp = double.Parse(txtVP.Text);
                    n = double.Parse(txtNPeriodos.Text);
                    n = (n * vlr2) / vlr;

                    i = 1 / n * ((vf / vp) - 1);
                    i = i * 100;
                    txtTI.Text = i.ToString("0.00");
                }
                if (cmbIS.SelectedItem.Equals("Número de periodos"))
                {
                    vf = double.Parse(txtVF.Text);
                    vp = double.Parse(txtVP.Text);
                    i = double.Parse(txtTI.Text);
                    i = i / 100;

                    n = 1 / i * ((vf / vp) - 1);
                    Math.Truncate(n);
                    txtNPeriodos.Text = n.ToString("0.00");

                }
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
                txtVP.Text = 0.ToString();
                txtVF.Enabled = true;
                txtVF.Text = "";
                txtTI.Enabled = true;
                txtTI.Text = "";
                txtNPeriodos.Enabled = true;
                txtNPeriodos.Text = "";

            }
            if (cmbIS.SelectedItem.Equals("Valor futuro"))
            {
                txtVP.Enabled = true;
                txtVP.Text = "";
                txtVF.Enabled = false;
                txtVF.Text = 0.ToString();
                txtTI.Enabled = true;
                txtTI.Text = "";
                txtNPeriodos.Enabled = true;
                txtNPeriodos.Text = "";
            }
            if (cmbIS.SelectedItem.Equals("Tasa de interés"))
            {
                txtVP.Enabled = true;
                txtVP.Text = "";
                txtVF.Enabled = true;
                txtVF.Text = "";
                txtTI.Enabled = false;
                txtTI.Text = 0.ToString();
                txtNPeriodos.Enabled = true;
                txtNPeriodos.Text = "";

            }
            if (cmbIS.SelectedItem.Equals("Número de periodos"))
            {
                txtVP.Enabled = true;
                txtVP.Text = "";
                txtVF.Enabled = true;
                txtVF.Text = "";
                txtTI.Enabled = true;
                txtTI.Text = "";
                txtNPeriodos.Enabled = false;
                txtNPeriodos.Text = 0.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtVP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVF_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNPeriodos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtVF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtTI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtNPeriodos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }
    }
}

