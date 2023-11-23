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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            cmbType.Text = " ";
            txtIncome.Clear();
            lblPay.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm if you want to Exit", "Exit Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int t;
            double income = 0.0, pay = 0.0;
            t = Convert.ToInt32(cmbType.Text);
            if (t == 5)
            {
                txtIncome.Enabled = false;
                lblPay.Text = 1000000.00.ToString();
            }
            else
            {    
                txtIncome.Enabled = true;
                income = Convert.ToDouble(txtIncome.Text);
                switch (t)
                {
                    case 1 : pay = income * 0.01; break;
                    case 2: pay = income * 0.008;break;
                    case 3:pay = income * 0.005;break;
                    case 4: pay = income * 0.003;break;
                    
                }                lblPay.Text = pay.ToString();
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
