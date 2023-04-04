namespace DbProject.Component
{
    partial class AddEdit
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
            this.StatusText = new System.Windows.Forms.ComboBox();
            this.ProjectText = new System.Windows.Forms.ComboBox();
            this.Project = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.Studentregno = new System.Windows.Forms.Label();
            this.studenttext = new System.Windows.Forms.ComboBox();
            this.projectConfirm = new System.Windows.Forms.Button();
            this.StudentConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusText
            // 
            this.StatusText.Enabled = false;
            this.StatusText.FormattingEnabled = true;
            this.StatusText.Location = new System.Drawing.Point(184, 196);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(200, 21);
            this.StatusText.TabIndex = 73;
            // 
            // ProjectText
            // 
            this.ProjectText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectText.FormattingEnabled = true;
            this.ProjectText.Location = new System.Drawing.Point(184, 52);
            this.ProjectText.Name = "ProjectText";
            this.ProjectText.Size = new System.Drawing.Size(200, 21);
            this.ProjectText.TabIndex = 72;
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project.Location = new System.Drawing.Point(12, 57);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(88, 16);
            this.Project.TabIndex = 71;
            this.Project.Text = "Project No :";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(170, 309);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 43);
            this.Submit.TabIndex = 70;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(12, 201);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(58, 16);
            this.Status.TabIndex = 69;
            this.Status.Text = "Status :";
            // 
            // Studentregno
            // 
            this.Studentregno.AutoSize = true;
            this.Studentregno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentregno.Location = new System.Drawing.Point(12, 122);
            this.Studentregno.Name = "Studentregno";
            this.Studentregno.Size = new System.Drawing.Size(120, 16);
            this.Studentregno.TabIndex = 74;
            this.Studentregno.Text = "Student RegNo :";
            // 
            // studenttext
            // 
            this.studenttext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studenttext.FormattingEnabled = true;
            this.studenttext.Location = new System.Drawing.Point(184, 117);
            this.studenttext.Name = "studenttext";
            this.studenttext.Size = new System.Drawing.Size(200, 21);
            this.studenttext.TabIndex = 75;
            // 
            // projectConfirm
            // 
            this.projectConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.projectConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectConfirm.Location = new System.Drawing.Point(412, 47);
            this.projectConfirm.Name = "projectConfirm";
            this.projectConfirm.Size = new System.Drawing.Size(74, 29);
            this.projectConfirm.TabIndex = 76;
            this.projectConfirm.Text = "Confirm";
            this.projectConfirm.UseVisualStyleBackColor = false;
            this.projectConfirm.Click += new System.EventHandler(this.projectConfirm_Click);
            // 
            // StudentConfirm
            // 
            this.StudentConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.StudentConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentConfirm.Location = new System.Drawing.Point(412, 112);
            this.StudentConfirm.Name = "StudentConfirm";
            this.StudentConfirm.Size = new System.Drawing.Size(74, 29);
            this.StudentConfirm.TabIndex = 77;
            this.StudentConfirm.Text = "Confirm";
            this.StudentConfirm.UseVisualStyleBackColor = false;
            this.StudentConfirm.Click += new System.EventHandler(this.StudentConfirm_Click);
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.StudentConfirm);
            this.Controls.Add(this.projectConfirm);
            this.Controls.Add(this.studenttext);
            this.Controls.Add(this.Studentregno);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.ProjectText);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Status);
            this.Name = "AddEdit";
            this.Text = "AddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusText;
        private System.Windows.Forms.ComboBox ProjectText;
        private System.Windows.Forms.Label Project;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Studentregno;
        private System.Windows.Forms.ComboBox studenttext;
        private System.Windows.Forms.Button projectConfirm;
        private System.Windows.Forms.Button StudentConfirm;
    }
}