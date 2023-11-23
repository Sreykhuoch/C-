using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_mgt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsConnection.con.ConnectionString = "Data Source = DESKTOP-7P1JC9A ; Initial Catalog = Order_mgt ;Integrated Security = true";
            try
            {
                clsConnection.con.Open();
                //MessageBox.Show("connecttion succsecsfull");
            }
            catch (Exception)
            {
                MessageBox.Show("connecttion un-succsecsfull");
            }
        }

        private void timer_Click(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
