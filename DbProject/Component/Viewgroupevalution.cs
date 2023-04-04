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
    public partial class Viewgroupevalution : Form
    {
        DataGridViewRow PreviousRow;
        public Viewgroupevalution()
        {
            InitializeComponent();
        }

        private void Viewgroupevalution_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Name,TotalMarks,TotalWeightage, GroupId,ObtainedMarks,EvaluationId from Evaluation t1 join GroupEvaluation t2 on t2.EvaluationId = t1.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int m = dataGridView1.Columns.Count;
            //DataGridViewColumn delete = dataGridView1.Columns["Delete"];
            DataGridViewColumn edit = dataGridView1.Columns["Edit"];
            //DataGridViewColumn Id = dataGridView1.Columns["Id"];
            //dataGridView1.Columns.RemoveAt(delete.Index);
            //dataGridView1.Columns.Insert(m - 1, delete);
            dataGridView1.Columns.RemoveAt(Edit.Index);
            //Id.Visible = false;
            dataGridView1.Columns.Insert(m - 2, Edit);
            //dataGridView1.Columns["Delete"].DisplayIndex = m - 1;
            dataGridView1.Columns["Edit"].DisplayIndex = m - 1;
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
                EvaluateGroup form = new EvaluateGroup(m, "Update");
                form.Show();
                //MessageBox.Show(m.ToString());
                //dataGridView1.Columns["Gender"].Visible = false;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
