namespace DbProject.Component
{
    partial class MakeGroup
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
            this.Submit = new System.Windows.Forms.Button();
            this.StudentRegText = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.StudentRegNO = new System.Windows.Forms.Label();
            this.CreatedOn = new System.Windows.Forms.Label();
            this.CreatedOnText1 = new System.Windows.Forms.DateTimePicker();
            this.Project = new System.Windows.Forms.Label();
            this.ProjectText = new System.Windows.Forms.ComboBox();
            this.StatusText = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(106, 382);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 43);
            this.Submit.TabIndex = 60;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // StudentRegText
            // 
            this.StudentRegText.Location = new System.Drawing.Point(212, 118);
            this.StudentRegText.Name = "StudentRegText";
            this.StudentRegText.Size = new System.Drawing.Size(200, 20);
            this.StudentRegText.TabIndex = 54;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(40, 273);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(58, 16);
            this.Status.TabIndex = 49;
            this.Status.Text = "Status :";
            // 
            // StudentRegNO
            // 
            this.StudentRegNO.AutoSize = true;
            this.StudentRegNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRegNO.Location = new System.Drawing.Point(40, 122);
            this.StudentRegNO.Name = "StudentRegNO";
            this.StudentRegNO.Size = new System.Drawing.Size(124, 16);
            this.StudentRegNO.TabIndex = 48;
            this.StudentRegNO.Text = "Student Reg No :";
            // 
            // CreatedOn
            // 
            this.CreatedOn.AutoSize = true;
            this.CreatedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedOn.Location = new System.Drawing.Point(40, 56);
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.Size = new System.Drawing.Size(93, 16);
            this.CreatedOn.TabIndex = 47;
            this.CreatedOn.Text = "Created On :";
            // 
            // CreatedOnText1
            // 
            this.CreatedOnText1.Location = new System.Drawing.Point(212, 52);
            this.CreatedOnText1.Name = "CreatedOnText1";
            this.CreatedOnText1.Size = new System.Drawing.Size(200, 20);
            this.CreatedOnText1.TabIndex = 64;
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project.Location = new System.Drawing.Point(40, 196);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(88, 16);
            this.Project.TabIndex = 65;
            this.Project.Text = "Project No :";
            // 
            // ProjectText
            // 
            this.ProjectText.FormattingEnabled = true;
            this.ProjectText.Location = new System.Drawing.Point(212, 191);
            this.ProjectText.Name = "ProjectText";
            this.ProjectText.Size = new System.Drawing.Size(200, 21);
            this.ProjectText.TabIndex = 67;
            this.ProjectText.DropDownStyle  = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // StatusText
            // 
            this.StatusText.Enabled = false;
            this.StatusText.FormattingEnabled = true;
            this.StatusText.Location = new System.Drawing.Point(212, 268);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(200, 21);
            this.StatusText.TabIndex = 68;
            // 
            // MakeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 484);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.ProjectText);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.CreatedOnText1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.StudentRegText);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StudentRegNO);
            this.Controls.Add(this.CreatedOn);
            this.MaximizeBox = false;
            this.Name = "MakeGroup";
            this.Text = "MakeGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox StudentRegText;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label StudentRegNO;
        private System.Windows.Forms.Label CreatedOn;
        private System.Windows.Forms.DateTimePicker CreatedOnText1;
        private System.Windows.Forms.Label Project;
        private System.Windows.Forms.ComboBox ProjectText;
        private System.Windows.Forms.ComboBox StatusText;
    }
}