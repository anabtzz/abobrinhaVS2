using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abobrinha2._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txtnumtab.Clear();
            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double numtab, result;
            int i;
            numtab = Convert.ToDouble(txtnumtab.Text);
            i = 0;
            while (i <= 10) 
            {
                result = numtab * i;
                i++;

                txtresultado.Text = String.Concat(txtresultado.Text, " \n\n", result.ToString());
            }
        }

        private void txtnumtab_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double numtab, result;
            
            numtab = Convert.ToDouble(txtnumtab.Text);
            
            for (int i = 0; i <= 10; i++)
            {
                result = numtab * i;
               
                txtresultado.Text = String.Concat(txtresultado.Text, " \n\n", result.ToString());
            }
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double numtab, result;
            int i;

            numtab = Convert.ToDouble(txtnumtab.Text);

            i = 0;
            do
            {
                result = numtab * i;
                i++;

                txtresultado.Text = String.Concat(txtresultado.Text, " \n\n", result.ToString());
            } while (i <= 10);
        }
    }
}
