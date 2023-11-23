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

namespace Employee_Managment
{
    public partial class Form1 : Form
    {
        //Public declearation
        //create database connection via windows authentication
         SqlConnection con = new SqlConnection("Data Source = DESKTOP-7P1JC9A ; Initial Catalog = NUM_DB_Y3S1_2023;" +
         "Integrated Security = true");

        //create database connection via sql server authentication
        //SqlConnection con = new SqlConnection("Data Source = DESKTOP-7P1JC9A ; Initial Catalog = NUM_DB_Y3S1_2023;" +
         //  "UID = sa ; PWD = 123;");

        DataTable dt = new DataTable();
       

        public Form1()
        {
            InitializeComponent();
        }
        ​​

        //user define function : getdata
        private void GetData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblEmployee", con);
            dt.Clear();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
            dgvEmployee.Columns[0].HeaderText = "EmployeeID";
            dgvEmployee.Columns[1].HeaderText = "Name";
            dgvEmployee.Columns[2].HeaderText = "Date of Birth";
            dgvEmployee.Columns[3].HeaderText = "Salary";
            dgvEmployee.Columns["EmpID"].Width = 200;
            dgvEmployee.Columns["EmpName"].Width = 370;
            dgvEmployee.Columns["DOB"].Width = 300;
            dgvEmployee.Columns["Salary"].Width = 250;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Tahama", 14, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            GetData();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Index = e.RowIndex;
                DataGridViewRow SelectRow = dgvEmployee.Rows[Index];
                txtID.Text = SelectRow.Cells["EmpID"].Value.ToString();
                txtName.Text = SelectRow.Cells["EmpName"].Value.ToString();
                txtDOB.Text  = Convert.ToDateTime(SelectRow.Cells["DoB"].Value).ToString("dd/MM/yyyy");
                txtSalary.Text = SelectRow.Cells["Salary"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtID.Text = "";
            txtName.Clear();
            txtDOB.Clear();
            txtSalary.Clear();
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert Into tblEmployee ( EmpName, DOB, Salary) Values('" + txtName.Text + "', '" + DateTime.Parse(txtDOB.Text) + "', '" + Double.Parse(txtSalary.Text) + "') ", con);
                cmd.ExecuteNonQuery();
                GetData();
                clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult iDelete = DialogResult.OK;
            iDelete = MessageBox.Show("Comfirm if you want to delete this record", "Delete record ....!", MessageBoxButtons.YesNo,MessageBoxIcon.Question );
            if (iDelete == DialogResult.Yes) {
                SqlCommand cmd = new SqlCommand("Delete from tblEmployee where ID = ' " + int.Parse(txtID.Text) + "'", con);
                cmd.ExecuteNonQuery();
                GetData();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update tblEmployee Set " +
                " EmpName = ' "+txtName.Text+"', " +
                " DOB = ' "+DateTime.Parse(txtDOB.Text)+"'," +
                " Salary ='  " + double.Parse(txtSalary.Text)+"' " +
                " Where EmpID =  ' " + int.Parse(txtID.Text)+"' ", con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update data successfully .....!!! ", "Update Data");
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
         
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you to leave the program.......!", "Exit the program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From tblEmployee" +
                               " Where EmpName= '" + txtSearch.Text + "'", con);
            dt.Clear();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
            
        }
    }

    internal class sqlConnection
    {
        internal void open()
        {
            throw new NotImplementedException();
        }

        public static implicit operator sqlConnection(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}
