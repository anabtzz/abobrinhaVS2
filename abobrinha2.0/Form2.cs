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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtlitros.Clear();
            txtcomb.Clear();
            txtresult.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double litros, result;
            String cod;

            litros = Convert.ToDouble(txtlitros.Text);
            cod = Convert.ToString(txtcomb.Text);

            if (cod.Equals("A"))

                if (litros <= 20)
                {
                    result = litros * (4.30 - 4.30 * 3 / 100);
                    txtresult.Text = result.ToString();

                }
            if (litros > 20)
            {
                result = litros * (4.30 - 4.30 * 5 / 100);
                txtresult.Text = result.ToString();
            }
            else

            if (cod.Equals("G"))


                if (litros <= 20)
                {
                    result = litros * (5.50 - 5.50 * 5 / 100);
                    txtresult.Text = result.ToString();
                }
            if (litros > 20)
            {
                result = litros * (5.50 - 5.50 * 6 / 100);
                txtresult.Text = result.ToString();
            }

        }
    }
}
            
        
    


      