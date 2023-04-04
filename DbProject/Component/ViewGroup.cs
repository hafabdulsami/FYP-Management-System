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
    public partial class ViewGroup : Form
    {
        public ViewGroup()
        {
            InitializeComponent();
        }

        private void ViewGroup_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Title,RegistrationNo, Created_On ,Status from [Group] t1 join GroupStudent t2 on t1.Id = t2.GroupId join Student t3 on t2.StudentId = t3.Id join GroupProject t4 on t1.Id = t4.GroupId join Project t5 on t4.ProjectId = t5.Id order by t4.GroupId ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
