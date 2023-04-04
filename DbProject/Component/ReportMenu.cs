using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject.Component
{
    public partial class ReportMenu : Form
    {
        ToolStripMenuItem menu = null;
        Form hide = null;
        public ReportMenu()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.SeaGreen; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.SeaGreen; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.SeaGreen; }
            }
        }

        private void AddEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(AddEntityToolStripMenuItem);
            AdvisorProject View = new AdvisorProject("Select CONCAT(FirstName,LastName) As [Name],t4.Value ,Title  ,AssignmentDate ,t3.Email from Project t1 JOIN ProjectAdvisor t2 on t1.Id = t2.ProjectId JOIN Person t3 on t3.Id = t2.AdvisorId join Lookup t4 on AdvisorRole = t4.Id");
            ChangeForm(View);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/AdvisorProject.pdf";
            Document DC = new Document();
            FileStream FS = File.Create(path);
            PdfWriter.GetInstance(DC, FS);
            DC.Open();
            DC.Add(new Paragraph(""));
            var c = Configuration.getInstance().getConnection();


            SqlCommand sc = new SqlCommand("Select CONCAT(FirstName,LastName) As [Name],Title  from Project t1 JOIN ProjectAdvisor t2 on t1.Id = t2.ProjectId JOIN Person t3 on t3.Id = t2.AdvisorId join Lookup t4 on AdvisorRole = t4.Id", c);
            SqlDataReader reader;

            reader = sc.ExecuteReader();

            DC.Add(new Paragraph("Name                      Title"));
            while (reader.Read())
            {
                string reg = reader["Name"].ToString();
                
                string Title = reader["Title"].ToString();
               
                DC.Add(new Paragraph(reg + "          " + Title));

            }

            reader.Close();

            DC.Close();
        }

        private void ChangeColor(ToolStripMenuItem Selected)
        {
            if (menu != null)
            {
                string MyColor = "#0B0D14";
                menu.BackColor = ColorTranslator.FromHtml(MyColor);
            }
            menu = Selected;
            menu.BackColor = Color.SeaGreen;

        }

        private void ChangeForm(Form show)
        {
            if (hide != null)
            {
                hide.Hide();
            }
            hide = show;
            show.StartPosition = FormStartPosition.Manual;
            show.Location = new Point(this.Left + 6, this.Top + 55);
            show.Show();
        }

        private void ViewEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ViewEntityToolStripMenuItem);
            AdvisorProject view = new AdvisorProject("Select RegistrationNo, t2.Status ,t5.Title, CONCAT(FirstName,LastName) as [Name] from Student t1 join GroupStudent t2 on t1.Id = t2.StudentId join [Group] t3 on t2.GroupId = t3.Id join GroupProject t4 on t4.GroupId = t3.Id join Project t5 on t5.Id = t4.ProjectId join ProjectAdvisor t6 on t5.Id = t6.ProjectId join Person t7 on t6.AdvisorId = t7.Id");
            ChangeForm(view);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/StudentAdvisor.pdf";
            Document DC = new Document();
            FileStream FS = File.Create(path);
            PdfWriter.GetInstance(DC, FS);
            DC.Open();
            DC.Add(new Paragraph(""));
            var c = Configuration.getInstance().getConnection();


            SqlCommand sc = new SqlCommand("Select RegistrationNo, t2.Status ,t5.Title, CONCAT(FirstName,LastName) as [Name] from Student t1 join GroupStudent t2 on t1.Id = t2.StudentId join [Group] t3 on t2.GroupId = t3.Id join GroupProject t4 on t4.GroupId = t3.Id join Project t5 on t5.Id = t4.ProjectId join ProjectAdvisor t6 on t5.Id = t6.ProjectId join Person t7 on t6.AdvisorId = t7.Id", c);
            SqlDataReader reader;

            reader = sc.ExecuteReader();

            DC.Add(new Paragraph("REGNO           Status          Title                                    Name"));
            while (reader.Read())
            {
                string reg = reader["RegistrationNo"].ToString();
                string ststus = reader["Status"].ToString();
                string Title = reader["Title"].ToString();
                string Name = reader["Name"].ToString();
                DC.Add(new Paragraph(reg+"          "+ststus+"          "+Title+"           "+Name));

            }

            reader.Close();

            DC.Close();
        }

        private void EditEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(EditEntityToolStripMenuItem);
            AdvisorProject view = new AdvisorProject("Select RegistrationNo From Student Except Select RegistrationNo From Student as s Join GroupStudent as gs On gs.StudentId = s.Id Join GroupProject as gp On gp.GroupId = gs.GroupId Join ProjectAdvisor as pa On pa.ProjectId = gp.ProjectId");
            ChangeForm(view);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/MissingAdvisorReport.pdf";
            Document DC = new Document();
            FileStream FS = File.Create(path);
            PdfWriter.GetInstance(DC, FS);
            DC.Open();
            DC.Add(new Paragraph(""));
            var c = Configuration.getInstance().getConnection();


            SqlCommand sc = new SqlCommand("Select RegistrationNo From Student Except Select RegistrationNo From Student as s Join GroupStudent as gs On gs.StudentId = s.Id Join GroupProject as gp On gp.GroupId = gs.GroupId Join ProjectAdvisor as pa On pa.ProjectId = gp.ProjectId", c);
            SqlDataReader reader;

            reader = sc.ExecuteReader();

            DC.Add(new Paragraph("REGISTRATION NO"));
            while (reader.Read())
            {
                string reg = reader["RegistrationNo"].ToString();
                DC.Add(new Paragraph(reg));

            }

            reader.Close();

            DC.Close();
        }

        private void DeleteEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(DeleteEntityToolStripMenuItem);
            AdvisorProject view = new AdvisorProject("Select Id , [Name], TotalMarks from Evaluation");
            ChangeForm(view);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Evaluation.pdf";
            Document DC = new Document();
            FileStream FS = File.Create(path);
            PdfWriter.GetInstance(DC, FS);
            DC.Open();
            DC.Add(new Paragraph(""));
            var c = Configuration.getInstance().getConnection();


            SqlCommand sc = new SqlCommand("Select Id , [Name], TotalMarks from Evaluation", c);
            SqlDataReader reader;

            reader = sc.ExecuteReader();

            DC.Add(new Paragraph("Id                      Name"));
            while (reader.Read())
            {
                string reg = reader["Id"].ToString();

                string Title = reader["Name"].ToString();

                DC.Add(new Paragraph(reg + "          " + Title));

            }

            reader.Close();

            DC.Close();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeColor(toolStripMenuItem1);
            AdvisorProject view = new AdvisorProject("Select FirstName,LastName, RegistrationNo ,contact,Email from Person t1 Join Student t2 on t1.Id = t2.Id");
            ChangeForm(view);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Totalstudent.pdf";
            Document DC = new Document();
            FileStream FS = File.Create(path);
            PdfWriter.GetInstance(DC, FS);
            DC.Open();
            DC.Add(new Paragraph(""));
            var c = Configuration.getInstance().getConnection();


            SqlCommand sc = new SqlCommand("Select CONCAT(FirstName,LastName) AS [Name], RegistrationNo from Person t1 Join Student t2 on t1.Id = t2.Id", c);
            SqlDataReader reader;

            reader = sc.ExecuteReader();

            DC.Add(new Paragraph("Name                                    RegNo"));
            while (reader.Read())
            {
                string reg = reader["Name"].ToString();

                string Title = reader["RegistrationNo"].ToString();

                DC.Add(new Paragraph(reg + "                        " + Title));

            }

            reader.Close();

            DC.Close();
        }
    }
}
