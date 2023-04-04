namespace DbProject.Component
{
    partial class AddProject
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
            this.AdvisorRolebox = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.AdvisorRole = new System.Windows.Forms.Label();
            this.AdvisorBox = new System.Windows.Forms.ComboBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.Advisor = new System.Windows.Forms.Label();
            this.Assigmentdate = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.AssigmentdateText = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AdvisorRolebox
            // 
            this.AdvisorRolebox.FormattingEnabled = true;
            this.AdvisorRolebox.Location = new System.Drawing.Point(149, 265);
            this.AdvisorRolebox.Name = "AdvisorRolebox";
            this.AdvisorRolebox.Size = new System.Drawing.Size(245, 21);
            this.AdvisorRolebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdvisorRolebox.TabIndex = 63;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(89, 385);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 43);
            this.Submit.TabIndex = 60;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AdvisorRole
            // 
            this.AdvisorRole.AutoSize = true;
            this.AdvisorRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvisorRole.Location = new System.Drawing.Point(22, 270);
            this.AdvisorRole.Name = "AdvisorRole";
            this.AdvisorRole.Size = new System.Drawing.Size(105, 16);
            this.AdvisorRole.TabIndex = 59;
            this.AdvisorRole.Text = "Advisor Role :";
            // 
            // AdvisorBox
            // 
            this.AdvisorBox.FormattingEnabled = true;
            this.AdvisorBox.Location = new System.Drawing.Point(149, 195);
            this.AdvisorBox.Name = "AdvisorBox";
            this.AdvisorBox.Size = new System.Drawing.Size(245, 21);
            this.AdvisorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdvisorBox.TabIndex = 58;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(149, 65);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(245, 20);
            this.descriptionText.TabIndex = 54;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(149, 23);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(245, 20);
            this.titleText.TabIndex = 53;
            // 
            // Advisor
            // 
            this.Advisor.AutoSize = true;
            this.Advisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor.Location = new System.Drawing.Point(22, 200);
            this.Advisor.Name = "Advisor";
            this.Advisor.Size = new System.Drawing.Size(68, 16);
            this.Advisor.TabIndex = 52;
            this.Advisor.Text = "Advisor :";
            // 
            // Assigmentdate
            // 
            this.Assigmentdate.AutoSize = true;
            this.Assigmentdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assigmentdate.Location = new System.Drawing.Point(22, 138);
            this.Assigmentdate.Name = "Assigmentdate";
            this.Assigmentdate.Size = new System.Drawing.Size(124, 16);
            this.Assigmentdate.TabIndex = 51;
            this.Assigmentdate.Text = "Assigment Date :";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(22, 69);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(94, 16);
            this.Description.TabIndex = 48;
            this.Description.Text = "Description :";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(22, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(46, 16);
            this.Title.TabIndex = 47;
            this.Title.Text = "Title :";
            // 
            // AssigmentdateText
            // 
            this.AssigmentdateText.Location = new System.Drawing.Point(152, 134);
            this.AssigmentdateText.Name = "AssigmentdateText";
            this.AssigmentdateText.Size = new System.Drawing.Size(242, 20);
            this.AssigmentdateText.TabIndex = 57;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.AdvisorRolebox);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.AdvisorRole);
            this.Controls.Add(this.AdvisorBox);
            this.Controls.Add(this.AssigmentdateText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.Advisor);
            this.Controls.Add(this.Assigmentdate);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.MaximizeBox = false;
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AdvisorRolebox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label AdvisorRole;
        private System.Windows.Forms.ComboBox AdvisorBox;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label Advisor;
        private System.Windows.Forms.Label Assigmentdate;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DateTimePicker AssigmentdateText;
    }
}