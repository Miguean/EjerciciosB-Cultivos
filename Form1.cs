using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Seguro_de_cultivos
{
    public partial class E6 : Form
    {
        double Total = 0;
        public E6()
        {
            InitializeComponent();
        }

        private void lstSemillas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbxDinero.Text !="" && tbxHectareas.Text != "")
            {
                switch (lstSemillas.SelectedIndex)
                {
                    case 0:
                        Total += (Convert.ToDouble(tbxDinero.Text) * .35 * (Convert.ToDouble(tbxHectareas.Text)));
                        tbxHectT.Text = tbxHectareas.Text;
                        tbxDinero.Clear();
                        tbxHectareas.Clear();
                        tbxDinero.Focus();
                        break;
                    case 1:
                        Total += (Convert.ToDouble(tbxDinero.Text) * .35 * (Convert.ToDouble(tbxHectareas.Text)));
                        tbxHectC.Text = tbxHectareas.Text;
                        tbxDinero.Clear();
                        tbxHectareas.Clear();
                        tbxDinero.Focus();
                        break;
                    case 2:
                        Total += (Convert.ToDouble(tbxDinero.Text) * .35 * (Convert.ToDouble(tbxHectareas.Text)));
                        tbxHectA.Text = tbxHectareas.Text;
                        tbxDinero.Clear();
                        tbxHectareas.Clear();
                        tbxDinero.Focus();
                        break;
                }
                lstSemillas.Enabled = false;
            }
            else
            {
                tbxDinero.Focus();
            }
        }

        private void tbxDinero_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            tbxTotal.Text = Total.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Total = 0;
            tbxDinero.Clear();
            tbxHectareas.Clear();
            tbxHectC.Clear();
            tbxHectT.Clear();
            tbxHectA.Clear();
            tbxTotal.Clear();
            tbxDinero.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxHectareas_TextChanged(object sender, EventArgs e)
        {
            lstSemillas.Enabled = true;
        }
    }
}
