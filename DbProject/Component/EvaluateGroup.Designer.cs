namespace DbProject.Component
{
    partial class EvaluateGroup
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
            this.EvaluationDateText = new System.Windows.Forms.DateTimePicker();
            this.ObtainMarksText = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.GroupIDText = new System.Windows.Forms.ComboBox();
            this.EvaluationNameText = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(111, 352);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 43);
            this.Submit.TabIndex = 60;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // EvaluationDateText
            // 
            this.EvaluationDateText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EvaluationDateText.Location = new System.Drawing.Point(213, 272);
            this.EvaluationDateText.Name = "EvaluationDateText";
            this.EvaluationDateText.Size = new System.Drawing.Size(200, 20);
            this.EvaluationDateText.TabIndex = 57;
            // 
            // ObtainMarksText
            // 
            this.ObtainMarksText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObtainMarksText.Location = new System.Drawing.Point(213, 188);
            this.ObtainMarksText.Name = "ObtainMarksText";
            this.ObtainMarksText.Size = new System.Drawing.Size(200, 20);
            this.ObtainMarksText.TabIndex = 55;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.Location = new System.Drawing.Point(41, 276);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(125, 16);
            this.DateOfBirth.TabIndex = 51;
            this.DateOfBirth.Text = "Evaluation Date :";
            // 
            // Contact
            // 
            this.Contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(41, 192);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(106, 16);
            this.Contact.TabIndex = 49;
            this.Contact.Text = "Obtain Marks :";
            // 
            // SecondName
            // 
            this.SecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondName.Location = new System.Drawing.Point(41, 126);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(133, 16);
            this.SecondName.TabIndex = 48;
            this.SecondName.Text = "Evaluation Name :";
            // 
            // ProjectName
            // 
            this.ProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(41, 59);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(76, 16);
            this.ProjectName.TabIndex = 47;
            this.ProjectName.Text = "Group ID :";
            // 
            // GroupIDText
            // 
            this.GroupIDText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupIDText.FormattingEnabled = true;
            this.GroupIDText.Location = new System.Drawing.Point(213, 54);
            this.GroupIDText.Name = "GroupIDText";
            this.GroupIDText.Size = new System.Drawing.Size(200, 21);
            this.GroupIDText.TabIndex = 61;
            // 
            // EvaluationNameText
            // 
            this.EvaluationNameText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EvaluationNameText.FormattingEnabled = true;
            this.EvaluationNameText.Location = new System.Drawing.Point(213, 121);
            this.EvaluationNameText.Name = "EvaluationNameText";
            this.EvaluationNameText.Size = new System.Drawing.Size(200, 21);
            this.EvaluationNameText.TabIndex = 62;
            // 
            // EvaluateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 469);
            this.Controls.Add(this.EvaluationNameText);
            this.Controls.Add(this.GroupIDText);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.EvaluationDateText);
            this.Controls.Add(this.ObtainMarksText);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.ProjectName);
            this.Name = "EvaluateGroup";
            this.Text = "EvaluteGroup";
            this.Load += new System.EventHandler(this.EvaluateGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DateTimePicker EvaluationDateText;
        private System.Windows.Forms.TextBox ObtainMarksText;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.ComboBox GroupIDText;
        private System.Windows.Forms.ComboBox EvaluationNameText;
    }
}