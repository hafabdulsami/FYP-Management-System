namespace DbProject.Component
{
    partial class ManageCURD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEntityToolStripMenuItem,
            this.ViewEntityToolStripMenuItem,
            this.EditEntityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddEntityToolStripMenuItem
            // 
            this.AddEntityToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEntityToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.AddEntityToolStripMenuItem.Name = "AddEntityToolStripMenuItem";
            this.AddEntityToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.AddEntityToolStripMenuItem.Text = "Add Entity";
            this.AddEntityToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // ViewEntityToolStripMenuItem
            // 
            this.ViewEntityToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEntityToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ViewEntityToolStripMenuItem.Name = "ViewEntityToolStripMenuItem";
            this.ViewEntityToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ViewEntityToolStripMenuItem.Text = "View Entity";
            this.ViewEntityToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // EditEntityToolStripMenuItem
            // 
            this.EditEntityToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEntityToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EditEntityToolStripMenuItem.Name = "EditEntityToolStripMenuItem";
            this.EditEntityToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.EditEntityToolStripMenuItem.Text = "Edit Entity";
            this.EditEntityToolStripMenuItem.Click += new System.EventHandler(this.EditEntityToolStripMenuItem_Click);
            // 
            // ManageCURD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ManageCURD";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageCURD_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ManageStudent_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddEntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewEntityToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem EditEntityToolStripMenuItem;
    }
}