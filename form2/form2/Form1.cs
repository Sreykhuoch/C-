using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdSex.Text = "M";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit = new DialogResult();
                iExit = MessageBox.Show("Comfirm if you want to exit ! ", "Exit Program", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(iExit == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSalary.Clear();
            txtPhone.Clear();
            cmdSex.Text = "M";

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double salary, tax;
            salary = double.Parse(txtSalary.Text);

            if (salary <= 250)
            {
                tax = 0;
            }
            else if(salary<=500){
                tax = (salary - 250) * 0.05;
            }
            else if (salary <= 1000)
            {
                tax = 12.5 + (salary - 500) * 0.08;
            }
            else
            {
                tax = 12.5 + 40 + (salary - 1000) * 0.1;
              
            }
            lbTax.Text = tax.ToString();
        }
    }
}
