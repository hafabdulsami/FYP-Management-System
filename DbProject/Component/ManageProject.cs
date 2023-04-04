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
    public partial class ManageProject : Form
    {
        ToolStripMenuItem menu = null;
        Form hide = null;
        public ManageProject()
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
            AddProject Project = new AddProject("Add", 0);
            ChangeForm(Project);
        }

        private void ViewEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColor(ViewEntityToolStripMenuItem);
            ViewProject project  = new ViewProject();
            ChangeForm(project);
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

        
    }
}
