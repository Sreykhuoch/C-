using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterms
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source = DESKTOP-7P1JC9A; Initial Catalog = MidtermExam;" + "Integrated Security = true");
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void GetData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblBook", con);
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Code";
            dgv.Columns[1].HeaderText = "Title";
            dgv.Columns[2].HeaderText = "Qty";
            dgv.Columns[3].HeaderText = "Price";
            dgv.Columns[4].HeaderText = "Author";
            dgv.Columns[5].HeaderText = "YearPublish";
            dgv.Columns["Code"].Width = 250;
            dgv.Columns["Title"].Width = 250;
            dgv.Columns["Qty"].Width = 200;
            dgv.Columns["Price"].Width = 180;
            dgv.Columns["Author"].Width = 200;
            dgv.Columns["YearPublish"].Width = 200;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahama", 13, FontStyle.Bold);

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Index = e.RowIndex;
                DataGridViewRow SelectRow = dgv.Rows[Index];
                txtcode.Text = SelectRow.Cells["Code"].Value.ToString();
                txtTitle.Text = SelectRow.Cells["Title"].Value.ToString();
                txtQty.Text = SelectRow.Cells["Qty"].Value.ToString();
                txtUnitprice.Text = SelectRow.Cells["Price"].Value.ToString();
                txtauthor.Text = SelectRow.Cells["Author"].Value.ToString();
                txtYPub.Text = SelectRow.Cells["YearPublish"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void clear()
        {
            txtcode.Text = "";
            txtTitle.Clear();
            txtQty.Text = "'";
            txtUnitprice.Text = "";
            txtauthor.Clear();
            txtYPub.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into tblBook (Title, Qty, Price, Author, YearPublish) " +
                "Values('" + txtTitle.Text + "', '" + int.Parse(txtQty.Text) + "', '" + Double.Parse(txtUnitprice.Text) + "', ' " + txtauthor.Text + "', ' " + int.Parse(txtYPub.Text) + "') ", con);
            cmd.ExecuteNonQuery();
            GetData();
            clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm if you want to Exit", "Exit Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult iDelete = DialogResult.OK;
            iDelete = MessageBox.Show("Comfirm if you want to delete this record", "Delete record ....!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iDelete == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete from tblBook where Code = ' " + int.Parse(txtcode.Text) + "'", con);
                cmd.ExecuteNonQuery();
                GetData();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update tblBook Set " +
                " Title = ' " + txtTitle.Text + "', " +
                " Qty = ' " + int.Parse(txtQty.Text) + "'," +
                " Price ='  " + double.Parse(txtUnitprice.Text) + "', " +
                " Author ='  " + txtauthor.Text + "', " +
                 " YearPublish ='  " + int.Parse(txtYPub.Text) + "' " +
                " Where Code =  ' " + int.Parse(txtcode.Text) + "' ", con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update data successfully .....!!! ", "Update Data");
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            txtcode.Text = "Auto Number";
            txtauthor.Clear();
            txtUnitprice.Clear();
            txtTitle.Clear();
            txtYPub.Clear();
            txtQty.Clear();
            txtsearch.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From tblBook" +
                " Where Title= '" + txtsearch.Text + "'", con);
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            GetData();
        }
    }
}
