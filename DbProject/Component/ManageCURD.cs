using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject.Component
{
    public partial class ManageCURD : Form
    {
        ToolStripMenuItem menu = null;
        Form hide = null;
        public ManageCURD( string option1, string option2, string option3, string option4)
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
            AddEntityToolStripMenuItem.Text = option1;
            ViewEntityToolStripMenuItem.Text = option2;
            EditEntityToolStripMenuItem.Text = option3;
           
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

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChangeColor(AddEntityToolStripMenuItem);
            AddEntity add = new AddEntity(0 , "Add");
            ChangeForm(add);
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ViewEntityToolStripMenuItem);
            rudEntity rud = new rudEntity();
            ChangeForm(rud);
        }

        private void ManageStudent_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(string.Format("X: {0} Y: {1}", MousePosition.X, MousePosition.Y));
        }
        private void ChangeColor(ToolStripMenuItem Selected)
        {
            if(menu != null)
            {
                string MyColor = "#0B0D14";
                menu.BackColor = ColorTranslator.FromHtml(MyColor);
            }
            menu = Selected;
            menu.BackColor = Color.SeaGreen;

        }
        
        private void ChangeForm(Form show)
        {
            if(hide != null)
            {
                hide.Hide();
            }
            hide = show;
            show.StartPosition = FormStartPosition.Manual;
            show.Location = new Point(this.Left + 6, this.Top + 55);
            show.Show();
        }

        private void EditEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageCURD_Load(object sender, EventArgs e)
        {

        }
    }
}
