using DbProject.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject
{
    public partial class MainMenu : Form
    {
        bool flag;
        Button Click = null;
        Form open = null;
        public MainMenu()
        {
            InitializeComponent();
            
        }

       

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if(flag)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    flag = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    flag = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
          //  flag = true;
        }

        private void MainMenu_MaximumSizeChanged(object sender, EventArgs e)
        {
            sidebar.Height = this.Size.Height;
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            //int m = this.Size.Height;
            //MessageBox.Show(m.ToString());
            sidebar.Height = this.Size.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hoo ja");
            //this.BackColor  = Color.White;
            //panel2.BackColor = Color.SeaGreen;
            //MessageBox.Show(panel2.BackColor.ToString());
            //panel2.Visible = true;
            //if(Click != null)
            //{
            //    Click.BackColor = Color.Black;
            //}
            //button4.BackColor = Color.SeaGreen;
            //Click = button4;
            ColorChange(button4);
            ManageCURD m = new ManageCURD( "Add Student", "View Student", "Edit Student", "Delete Student");
            // m.Left = 400;
     
            FormChange(m);
            /*m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(205, 23);
           // m.Top = 24;
           // m.Location(201, 24);
            m.Show();*/
          //  PanelVisible(ManageStudentPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (Click != null)
            //{
            //    Click.BackColor = Color.Black;
            //}
            //button1.BackColor = Color.SeaGreen;
            //Click = button1;
            ColorChange(button1);
            ManageAdvisor Advisor = new ManageAdvisor();
            FormChange(Advisor);
            
            //Advisor.Show();
            //PanelVisible(AddStudentPanel);
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            ColorChange(button3);
            ManageProject Project = new ManageProject();
            FormChange(Project);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorChange(button2);
            ManageGroup Group = new ManageGroup();
            FormChange(Group);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorChange(button5);
            ManageEvaluation Evaluation = new ManageEvaluation();
            FormChange(Evaluation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorChange(button6);
            ReportMenu Report = new ReportMenu();
            FormChange(Report);
        }
        
        public void ColorChange(Button button)
        {
            if (Click != null)
            {
                string MyColor = "#0B0D14"; 
                Click.BackColor = ColorTranslator.FromHtml(MyColor);
            }
            button.BackColor = Color.SeaGreen;
            Click = button;
        }

        public void FormChange(Form tryOpen)
        {
            if(open  != null)
            {
                open.Close();
            }
            open = tryOpen;
            open.StartPosition = FormStartPosition.Manual;
            open.Location = new Point(205, 23);
            open.Show();
        }

     
    }
}
