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
    public partial class ManageGroup : Form
    {

        ToolStripMenuItem menu = null;
        Form hide = null;

        public ManageGroup()
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
            MakeGroup Group = new MakeGroup("Add",0);
            ChangeColor(AddEntityToolStripMenuItem);
            ChangeForm(Group);
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
            AddEdit Student = new AddEdit("Add");
            ChangeColor(ViewEntityToolStripMenuItem); 
            ChangeForm(Student);
        }

        private void EditEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewGroup View = new ViewGroup();
            ChangeColor(EditEntityToolStripMenuItem);
            ChangeForm(View);
        }
    }
}
