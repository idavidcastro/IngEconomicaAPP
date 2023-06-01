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
    public partial class Amortizacion : Form
    {
        public Amortizacion()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularT_Click(object sender, EventArgs e)
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
                    txtRentaT.Text = r.ToString();
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
                    txtRentaT.Text = r.ToString();
                }
            }
        }
    }
}
