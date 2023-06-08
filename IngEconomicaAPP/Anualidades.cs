using System;
using System.Windows.Forms;

namespace IngEconomicaAPP
{
    public partial class Anualidades : Form
    {
        public Anualidades()
        {
            InitializeComponent();
            cmbTAnualidades.SelectedIndex = 1;
            cmbVS.SelectedIndex = 0;
            
            //cmbPeriodos2.SelectedIndex = 0;
            
        }

        private void cmbIS2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            //if (txtVA.Text == "")
            //    MessageBox.Show("EXISTEN CAMPOS VACIOS");
            //else if (txtVf.Text == "")
            //    MessageBox.Show("EXISTEN CAMPOS VACIOS");
            //else if (txtTIA.Text == "")
            //    MessageBox.Show("EXISTEN CAMPOS  VACIOS");
            //else if (txtNPeriodosA.Text == "")
            //    MessageBox.Show("");
            if (txtNPeriodosA.Text.Equals("") || txtRenta.Text.Equals("") || txtTIA.Text.Equals("") || txtVA.Text.Equals("") || txtVf.Text.Equals(""))
            {
                MessageBox.Show("EXISTEN CAMPOS VACIOS");
            }
            else
            {

                if (cmbTAnualidades.SelectedItem.Equals("Vencidas"))
                {

                    double vf = 0, va = 0, i = 0, n = 0, r = 0;
                    int vlr, vlr2;

                    if (cmbTI2.SelectedIndex == 0)
                    {
                        vlr = 12;
                    }
                    else if (cmbTI2.SelectedIndex == 1)
                    {
                        vlr = 6;
                    }
                    else if (cmbTI2.SelectedIndex == 2)
                    {
                        vlr = 3;
                    }
                    else if (cmbTI2.SelectedIndex == 3)
                    {
                        vlr = 2;
                    }
                    else
                    {
                        vlr = 1;
                    }


                    //////////////////////////////////////////////

                    if (cmbVS.SelectedItem.Equals("Valor actual"))
                    {
                        //double elevador;
                        //vf = double.Parse(txtVf.Text);
                        i = double.Parse(txtTIA.Text);
                        r = double.Parse(txtRenta.Text);
                        i = i / 100;

                        n = double.Parse(txtNPeriodosA.Text);

                        //n = (n * vlr2) / vlr;



                        va = r * (1 - Math.Pow((1 + i), -n)) / i;
                        Math.Truncate(va);
                        txtVA.Text = va.ToString("0.00");
                        
                    }

                    if (cmbVS.SelectedItem.Equals("Valor final"))
                    {
                        //va = double.Parse(txtVA.Text);
                        i = double.Parse(txtTIA.Text);
                        r = double.Parse(txtRenta.Text);
                        i = i / 100;
                        i = i / vlr;
                        n = double.Parse(txtNPeriodosA.Text);
                        //n = (n * vlr2) / vlr;

                        vf = r * (Math.Pow((1 + i), n) - 1) / i;
                        Math.Truncate(vf);
                        txtVf.Text = vf.ToString("0.00");
                    }
                    if (cmbVS.SelectedItem.Equals("Renta"))
                    {
                        va = double.Parse(txtVA.Text);
                        vf = double.Parse(txtVf.Text);
                        if (va != 0)
                        {
                            //vf = double.Parse(txtVf.Text);
                            //va = double.Parse(txtVA.Text);
                            n = double.Parse(txtNPeriodosA.Text);
                            //n = (n * vlr2) / vlr;
                            i = double.Parse(txtTIA.Text);
                            i = i / 100;
                            i = i / vlr;

                            r = (va * i) / (1 - Math.Pow((1 + i), -n));
                            Math.Truncate(r);
                            txtRenta.Text = r.ToString("0.00");
                        }
                        else
                        {
                            //vf = double.Parse(txtVf.Text);
                            //va = double.Parse(txtVA.Text);
                            n = double.Parse(txtNPeriodosA.Text);
                            //n = (n * vlr2) / vlr;
                            i = double.Parse(txtTIA.Text);
                            i = i / 100;
                            i = i / vlr;

                            r = (vf * i) / (Math.Pow((1 + i), n) - 1);
                            Math.Truncate(r);
                            txtRenta.Text = r.ToString("0.00");
                        }
                    }
                    if (cmbVS.SelectedItem.Equals("Número de periodos"))
                    {
                        vf = double.Parse(txtVf.Text);
                        va = double.Parse(txtVA.Text);

                        if (vf != 0)
                        {
                            i = double.Parse(txtTIA.Text);
                            r = double.Parse(txtRenta.Text);
                            i = i / 100;
                            i = i / vlr;

                            n = Math.Log((vf * i / va) + 1) / Math.Log(1 + i);
                            Math.Truncate(n);
                            txtNPeriodosA.Text = n.ToString("0.00");
                        }
                        else
                        {
                            i = double.Parse(txtTIA.Text);
                            r = double.Parse(txtRenta.Text);
                            i = i / 100;
                            i = i / vlr;

                            n = -Math.Log(1 - ((va * i) / r)) / Math.Log(1 + i);
                            Math.Truncate(n);
                            txtNPeriodosA.Text = n.ToString("0.00");
                        }

                    }

                }
                else
                {
                    double vf = 0, va = 0, i = 0, n = 0, r = 0;
                    int vlr, vlr2;

                    if (cmbTI2.SelectedIndex == 0)
                    {
                        vlr = 12;
                    }
                    else if (cmbTI2.SelectedIndex == 1)
                    {
                        vlr = 6;
                    }
                    else if (cmbTI2.SelectedIndex == 2)
                    {
                        vlr = 3;
                    }
                    else if (cmbTI2.SelectedIndex == 3)
                    {
                        vlr = 2;
                    }
                    else
                    {
                        vlr = 1;
                    }

                

                    //////////////////////////////////////////////

                    if (cmbVS.SelectedItem.Equals("Valor actual"))
                    {
                        //double elevador;
                        //vf = double.Parse(txtVf.Text);
                        i = double.Parse(txtTIA.Text);
                        r = double.Parse(txtRenta.Text);
                        i = i / 100;
                        i = i / vlr;
                        n = double.Parse(txtNPeriodosA.Text);

                        //n = (n * vlr2) / vlr;



                        va = r * ((1 - Math.Pow((1 + i), -n)) / i) * (1 + i);
                        Math.Truncate(va);
                        txtVA.Text = va.ToString("0.00");
                    }

                    if (cmbVS.SelectedItem.Equals("Valor final"))
                    {
                        //va = double.Parse(txtVA.Text);
                        i = double.Parse(txtTIA.Text);
                        r = double.Parse(txtRenta.Text);
                        i = i / 100;
                        i = i / vlr;
                        n = double.Parse(txtNPeriodosA.Text);
                        //n = (n * vlr2) / vlr;

                        vf = r * ((Math.Pow((1 + i), n) - 1) / i) * (1 + i);
                        Math.Truncate(vf);
                        txtVf.Text = vf.ToString("0.00");
                    }
                    if (cmbVS.SelectedItem.Equals("Renta"))
                    {
                        va = double.Parse(txtVA.Text);
                        vf = double.Parse(txtVf.Text);
                        if (va != 0)
                        {
                            //vf = double.Parse(txtVf.Text);
                            //va = double.Parse(txtVA.Text);
                            n = double.Parse(txtNPeriodosA.Text);
                            //n = (n * vlr2) / vlr;
                            i = double.Parse(txtTIA.Text);
                            i = i / 100;
                            i = i / vlr;

                            r = (va * i) / (1 + i) * (1 - Math.Pow((1 + i), -n));
                            Math.Truncate(r);
                            txtRenta.Text = r.ToString("0.00");
                        }
                        else
                        {
                            //vf = double.Parse(txtVf.Text);
                            //va = double.Parse(txtVA.Text);
                            n = double.Parse(txtNPeriodosA.Text);
                            //n = (n * vlr2) / vlr;
                            i = double.Parse(txtTIA.Text);
                            i = i / 100;
                            i = i / vlr;

                            r = (vf * i) / ((1 + i) * (Math.Pow((1 + i), n) - 1));
                            Math.Truncate(r);
                            txtRenta.Text = r.ToString("0.00");
                        }
                    }
                    if (cmbVS.SelectedItem.Equals("Número de periodos"))
                    {
                        vf = double.Parse(txtVf.Text);
                        va = double.Parse(txtVA.Text);

                        if (vf != 0)
                        {
                            i = double.Parse(txtTIA.Text);
                            r = double.Parse(txtRenta.Text);
                            i = i / 100;
                            i = i / vlr;

                            n = (Math.Log(vf * i + r * (1 + i)) - Math.Log(r * (1 + i))) / Math.Log(1 + i);
                            Math.Truncate(n);
                            txtNPeriodosA.Text = n.ToString("0.00");
                        }
                        else
                        {
                            i = double.Parse(txtTIA.Text);
                            r = double.Parse(txtRenta.Text);
                            i = i / 100;
                            i = i / vlr;

                            n = (Math.Log(r * (1 + i)) - Math.Log(r * (1 + i) - va * i)) / Math.Log(1 + i);
                            Math.Truncate(n);
                            txtNPeriodosA.Text = n.ToString("0.00");
                        }
                    }
                }
            }
        }
        private void LimpiarCampos()
        {
            txtVA.Text = "";
            txtVf.Text = "";
            txtTIA.Text = "";
            txtNPeriodosA.Text = "";
            txtRenta.Text = "";

        }
        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void cmbVS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVS.SelectedItem.Equals("Valor actual"))
            {
                
                txtVA.Enabled = false;
                txtVA.Text = 0.ToString();
                txtVf.Enabled = true;
                txtVf.Text = "";
                txtTIA.Enabled = true;
                txtTIA.Text = "";
                txtNPeriodosA.Enabled = true;
                txtNPeriodosA.Text = "";
                txtRenta.Enabled = true;
                txtRenta.Text = "";
                //LimpiarCampos();
            }
            if (cmbVS.SelectedItem.Equals("Valor final"))
            {
                txtVA.Enabled = true;
                txtVA.Text = "";
                txtVf.Enabled = false;
                txtVf.Text = 0.ToString();
                txtTIA.Enabled = true;
                txtTIA.Text = "";
                txtNPeriodosA.Enabled = true;
                txtNPeriodosA.Text = "";
                txtRenta.Enabled = true;
                txtRenta.Text = "";
                //LimpiarCampos();
            }
            if (cmbVS.SelectedItem.Equals("Número de periodos"))
            {
                txtVA.Enabled = true;
                txtVA.Text = "";
                txtVf.Enabled = true;
                txtVf.Text = "";
                txtTIA.Enabled = true;
                txtTIA.Text = "";
                txtNPeriodosA.Enabled = false;
                txtNPeriodosA.Text = 0.ToString();
                txtRenta.Enabled = true;
                txtRenta.Text = "";
                //LimpiarCampos();
            }
            if (cmbVS.SelectedItem.Equals("Renta"))
            {
                txtVA.Enabled = true;
                txtVA.Text = "";
                txtVf.Enabled = true;
                txtVf.Text = "";
                txtTIA.Enabled = true;
                txtTIA.Text = "";
                txtNPeriodosA.Enabled = true;
                txtNPeriodosA.Text = "";
                txtRenta.Enabled = false;
                txtRenta.Text = 0.ToString();
                //LimpiarCampos();
            }
        }

        private void txtVA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTIA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNPeriodosA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtVf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtTIA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtNPeriodosA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtRenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
        }
    }
}
