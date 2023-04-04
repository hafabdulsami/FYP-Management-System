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
    public partial class ViewProject : Form
    {
        DataGridViewRow PreviousRow;

        public ViewProject()
        {
            InitializeComponent();
        }

        private void ViewProject_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select CONCAT(FirstName,LastName) As [Name],t4.Value ,Title  ,AssignmentDate ,t3.Email from Project t1 JOIN ProjectAdvisor t2 on t1.Id = t2.ProjectId JOIN Person t3 on t3.Id = t2.AdvisorId join Lookup t4 on AdvisorRole = t4.Id  ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int m = dataGridView1.Columns.Count;
            DataGridViewColumn delete = dataGridView1.Columns["Delete"];
            DataGridViewColumn edit = dataGridView1.Columns["Edit"];
            DataGridViewColumn Id = dataGridView1.Columns["Id"];
            dataGridView1.Columns.RemoveAt(delete.Index);
            dataGridView1.Columns.Insert(m - 1, delete);
            dataGridView1.Columns.RemoveAt(Edit.Index);
            //Id.Visible = false;
            dataGridView1.Columns.Insert(m - 2, Edit);
            dataGridView1.Columns["Delete"].DisplayIndex = m - 1;
            dataGridView1.Columns["Edit"].DisplayIndex = m - 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                PreviousRow = dataGridView1.Rows[e.RowIndex];
                PreviousRow.ReadOnly = false;
                PreviousRow.Cells[0].ReadOnly = false;
                //PreviousRow.Cells[0].Visible = false;
                int m = int.Parse(PreviousRow.Cells[0].Value.ToString());
                AddProject form = new AddProject("Update", m);
                form.Show();
                //MessageBox.Show(m.ToString());
                //dataGridView1.Columns["Gender"].Visible = false;
            }
        }
    }
}
