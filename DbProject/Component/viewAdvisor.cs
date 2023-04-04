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

namespace DbProject.Component
{
    public partial class viewAdvisor : Form
    {
        DataGridViewRow PreviousRow;

        public viewAdvisor()
        {
            InitializeComponent();
        }

        private void viewAdvisor_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Advisor.Id AS ID ,FirstName,LastName,Contact,Email,DateOfBirth,Gender,Designation,Salary from Person INNER JOIN Advisor on Person.Id = Advisor.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int m = dataGridView1.Columns.Count;
           
            DataGridViewColumn edit = dataGridView1.Columns["Edit"];
            DataGridViewColumn Id = dataGridView1.Columns["Id"]; 
            //dataGridView1.Columns.RemoveAt(delete.Index);
           
            dataGridView1.Columns.RemoveAt(Edit.Index);
            Id.Visible = false;
            dataGridView1.Columns.Insert(m - 2, Edit);
            
            dataGridView1.Columns["Edit"].DisplayIndex = m - 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.RemoveAt(e.RowIndex);
                    ////MessageBox.Show(e.RowIndex.ToString());
                    //var con = Configuration.getInstance().getConnection();
                    //con.Open();
                    //string deleteOrdersQuery = "DELETE FROM Orders WHERE CustomerID = @customerId";
                    //using(SqlCommand com1 =new SqlCommand(deleteOrdersQuery,con))
                    //{
                    //
                    //}
                    //string sql = "DELETE FROM Person where Registra"
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                PreviousRow = dataGridView1.Rows[e.RowIndex];
                PreviousRow.ReadOnly = false;
                PreviousRow.Cells[0].ReadOnly = false;
                //PreviousRow.Cells[0].Visible = false;
                int m = int.Parse(PreviousRow.Cells[0].Value.ToString());
                AddAdvisor form = new AddAdvisor(m, "Update");
                form.Show();
                //MessageBox.Show(m.ToString());
                //dataGridView1.Columns["Gender"].Visible = false;
            }
        }
    }
}
