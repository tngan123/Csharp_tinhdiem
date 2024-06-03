using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tinhdiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double toan, van, tb;
            toan = Convert.ToDouble(txttoan.Text);
            van = Convert.ToDouble(txtvan.Text);

            tb = (toan + van) / 2;

            txttb.Text = tb.ToString();

            if (tb < 5)
            {
                txtxeploai.Text = "Yếu";
            }
            else if (tb <= 6) { txtxeploai.Text = "Yếu"; }
            else if (tb <= 6) { txtxeploai.Text = "Khá"; }
            else
            {
                txtxeploai.Text = "Giỏi";
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
