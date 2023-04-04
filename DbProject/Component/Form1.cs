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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading.Width += 3;
            if(loading.Width >= 799)
            {
                timer1.Stop();
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                
            }
        }
    }
}
