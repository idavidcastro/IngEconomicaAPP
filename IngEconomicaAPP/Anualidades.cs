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
    public partial class Anualidades : Form
    {
        public Anualidades()
        {
            InitializeComponent();
        }

        private void cmbIS2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            /* if (txtVA.Text == "")
                 MessageBox.Show("EXISTEN CAMPOS VACIOS");
             else if (txtVf.Text == "")
                 MessageBox.Show("EXISTEN CAMPOS VACIOS");
             else if (txtTIA.Text == "")
                 MessageBox.Show("EXISTEN CAMPOS  VACIOS");
             else if (txtNPeriodosA.Text == "")
                 MessageBox.Show(""); */



            if (cmbTAnualidades.SelectedItem.Equals("Vencidas")) {

                double vf = 0, va = 0, i = 0, n = 0, r = 0;
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

                if (cmbVS.SelectedItem.Equals("Valor Actual"))
                {
                    //double elevador;
                    //vf = double.Parse(txtVf.Text);
                    i = double.Parse(txtTIA.Text);
                    r = double.Parse(txtRenta.Text);
                    i = i / 100;

                    n = double.Parse(txtNPeriodosA.Text);

                    n = (n * vlr2) / vlr;



                    va = r * (1 - Math.Pow((1 + i), -n)) / i;
                    Math.Truncate(va);
                    txtVA.Text = va.ToString();
                }

                if (cmbVS.SelectedItem.Equals("Valor final"))
                {
                    //va = double.Parse(txtVA.Text);
                    i = double.Parse(txtTIA.Text);
                    r = double.Parse(txtRenta.Text);
                    i = i / 100;
                    n = double.Parse(txtNPeriodosA.Text);
                    n = (n * vlr2) / vlr;

                    vf = r * (Math.Pow((1 + i), n) - 1) / i;
                    Math.Truncate(vf);
                    txtVf.Text = vf.ToString();
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
                        n = (n * vlr2) / vlr;
                        i = double.Parse(txtTIA.Text);
                        i = i / 100;

                        r = (va * i) / (1 - Math.Pow((1 + i), -n));
                        Math.Truncate(r);
                        txtRenta.Text = r.ToString();
                    }
                    else
                    {
                        //vf = double.Parse(txtVf.Text);
                        //va = double.Parse(txtVA.Text);
                        n = double.Parse(txtNPeriodosA.Text);
                        n = (n * vlr2) / vlr;
                        i = double.Parse(txtTIA.Text);
                        i = i / 100;

                        r = (vf * i) / (Math.Pow((1 + i), n) - 1);
                        Math.Truncate(r);
                        txtRenta.Text = r.ToString();
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

                        n = Math.Log((vf*i / va)+1) / Math.Log(1 + i);
                        Math.Truncate(n);
                        txtNPeriodosA.Text = n.ToString();
                    }
                    else
                    {
                        i = double.Parse(txtTIA.Text);
                        r = double.Parse(txtRenta.Text);
                        i = i / 100;

                        n = - Math.Log(1 - ((va*i)/r)) / Math.Log(1 + i);
                        Math.Truncate(n);
                        txtNPeriodosA.Text = n.ToString();
                    }


                }

            } else
            {
                double vf = 0, va = 0, i = 0, n = 0, r = 0;
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

                if (cmbVS.SelectedItem.Equals("Valor Actual"))
                {
                    //double elevador;
                    //vf = double.Parse(txtVf.Text);
                    i = double.Parse(txtTIA.Text);
                    r = double.Parse(txtRenta.Text);
                    i = i / 100;

                    n = double.Parse(txtNPeriodosA.Text);

                    n = (n * vlr2) / vlr;



                    va = r * ((1 - Math.Pow((1 + i), -n)) / i) * (1+i);
                    Math.Truncate(va);
                    txtVA.Text = va.ToString();
                }

                if (cmbVS.SelectedItem.Equals("Valor final"))
                {
                    //va = double.Parse(txtVA.Text);
                    i = double.Parse(txtTIA.Text);
                    r = double.Parse(txtRenta.Text);
                    i = i / 100;
                    n = double.Parse(txtNPeriodosA.Text);
                    n = (n * vlr2) / vlr;

                    vf = r * ((Math.Pow((1 + i), n) - 1) / i) * (1+ i);
                    Math.Truncate(vf);
                    txtVf.Text = vf.ToString();
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
                        n = (n * vlr2) / vlr;
                        i = double.Parse(txtTIA.Text);
                        i = i / 100;

                        r = (va * i) /(1+i) * (1 - Math.Pow((1 + i), -n));
                        Math.Truncate(r);
                        txtRenta.Text = r.ToString();
                    }
                    else
                    {
                        //vf = double.Parse(txtVf.Text);
                        //va = double.Parse(txtVA.Text);
                        n = double.Parse(txtNPeriodosA.Text);
                        n = (n * vlr2) / vlr;
                        i = double.Parse(txtTIA.Text);
                        i = i / 100;
                        

                        r = (vf * i) / ((1+i)*(Math.Pow((1 + i), n) - 1));
                        Math.Truncate(r);
                        txtRenta.Text = r.ToString();
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

                        n = (Math.Log(vf*i+ r* (1+i)) - Math.Log(r*(1+i))) / Math.Log(1 + i);
                        Math.Truncate(n);
                        txtNPeriodosA.Text = n.ToString();
                    }
                    else
                    {
                        i = double.Parse(txtTIA.Text);
                        r = double.Parse(txtRenta.Text);
                        i = i / 100;

                        n = (Math.Log(r * (1 + i)) - Math.Log(r * (1 + i) - va * i)) / Math.Log(1 + i);
                        Math.Truncate(n);
                        txtNPeriodosA.Text = n.ToString();
                    }


                }
            }
           
        }
    }
}
