using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asain_cum_paymentt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            long n, i, s = 0;
            n = int.Parse(txtN.Text);
            for (i = 1; i <= n; i++)
            {
                s += i;
            }
            lblResult1.Text = s.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            long s = 0, a = 5;
            while (a <= 205)
            {
                s += a;
                a += 5;
            }
            lblResult2.Text = s.ToString();
        }
    }
}
