namespace DbProject.Component
{
    partial class AddEvaluation
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
            this.TotalWeightageText = new System.Windows.Forms.TextBox();
            this.TotalMarksText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(70, 330);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 43);
            this.Submit.TabIndex = 43;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TotalWeightageText
            // 
            this.TotalWeightageText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalWeightageText.Location = new System.Drawing.Point(177, 250);
            this.TotalWeightageText.Name = "TotalWeightageText";
            this.TotalWeightageText.Size = new System.Drawing.Size(178, 20);
            this.TotalWeightageText.TabIndex = 37;
            // 
            // TotalMarksText
            // 
            this.TotalMarksText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalMarksText.Location = new System.Drawing.Point(177, 169);
            this.TotalMarksText.Name = "TotalMarksText";
            this.TotalMarksText.Size = new System.Drawing.Size(178, 20);
            this.TotalMarksText.TabIndex = 36;
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.Location = new System.Drawing.Point(177, 102);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(178, 20);
            this.NameText.TabIndex = 35;
            // 
            // Contact
            // 
            this.Contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(12, 254);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(130, 16);
            this.Contact.TabIndex = 31;
            this.Contact.Text = "Total Weightage :";
            // 
            // SecondName
            // 
            this.SecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondName.Location = new System.Drawing.Point(12, 173);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(97, 16);
            this.SecondName.TabIndex = 30;
            this.SecondName.Text = "Total Marks :";
            // 
            // Name
            // 
            this.Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(12, 106);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(56, 16);
            this.Name.TabIndex = 29;
            this.Name.Text = "Name :";
            // 
            // AddEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.TotalWeightageText);
            this.Controls.Add(this.TotalMarksText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.Name);
            //this.Name = "ADDEvaluation";
            this.Text = "ADDEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox TotalWeightageText;
        private System.Windows.Forms.TextBox TotalMarksText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label Name;
    }
}