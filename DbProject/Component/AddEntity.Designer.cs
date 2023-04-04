namespace DbProject.Component
{
    partial class AddEntity
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
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.DateOfBirthText = new System.Windows.Forms.DateTimePicker();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.ContactText = new System.Windows.Forms.TextBox();
            this.SecondNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegNoText = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(209, 231);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(121, 21);
            this.GenderBox.TabIndex = 25;
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // DateOfBirthText
            // 
            this.DateOfBirthText.Location = new System.Drawing.Point(209, 189);
            this.DateOfBirthText.Name = "DateOfBirthText";
            this.DateOfBirthText.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthText.TabIndex = 24;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(209, 150);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 20);
            this.EmailText.TabIndex = 23;
            // 
            // ContactText
            // 
            this.ContactText.Location = new System.Drawing.Point(209, 110);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(100, 20);
            this.ContactText.TabIndex = 22;
            // 
            // SecondNameText
            // 
            this.SecondNameText.Location = new System.Drawing.Point(209, 68);
            this.SecondNameText.Name = "SecondNameText";
            this.SecondNameText.Size = new System.Drawing.Size(100, 20);
            this.SecondNameText.TabIndex = 21;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(209, 29);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(100, 20);
            this.FirstNameText.TabIndex = 20;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(37, 237);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(66, 16);
            this.Gender.TabIndex = 19;
            this.Gender.Text = "Gender :";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.Location = new System.Drawing.Point(37, 194);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(102, 16);
            this.DateOfBirth.TabIndex = 18;
            this.DateOfBirth.Text = "Date Of Birth :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(37, 155);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 16);
            this.Email.TabIndex = 17;
            this.Email.Text = "Email :";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(37, 115);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(67, 16);
            this.Contact.TabIndex = 16;
            this.Contact.Text = "Contact :";
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondName.Location = new System.Drawing.Point(37, 73);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(113, 16);
            this.SecondName.TabIndex = 15;
            this.SecondName.Text = "Second Name :";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(37, 34);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(90, 16);
            this.FirstName.TabIndex = 14;
            this.FirstName.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Reg No :";
            // 
            // RegNoText
            // 
            this.RegNoText.Location = new System.Drawing.Point(209, 279);
            this.RegNoText.Name = "RegNoText";
            this.RegNoText.Size = new System.Drawing.Size(100, 20);
            this.RegNoText.TabIndex = 27;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(104, 330);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 43);
            this.Submit.TabIndex = 28;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 421);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.RegNoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.DateOfBirthText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.ContactText);
            this.Controls.Add(this.SecondNameText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.FirstName);
            this.MaximizeBox = false;
            this.Name = "AddEntity";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddEntity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox ContactText;
        private System.Windows.Forms.TextBox SecondNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegNoText;
        private System.Windows.Forms.Button Submit;
    }
}