namespace DbProject.Component
{
    partial class AddAdvisor
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
            this.designation = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.salarytext = new System.Windows.Forms.TextBox();
            this.designationbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(143, 376);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(226, 43);
            this.Submit.TabIndex = 43;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(248, 229);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(200, 21);
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.TabIndex = 40;
            // 
            // DateOfBirthText
            // 
            this.DateOfBirthText.Location = new System.Drawing.Point(248, 182);
            this.DateOfBirthText.Name = "DateOfBirthText";
            this.DateOfBirthText.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthText.TabIndex = 39;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(248, 139);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(200, 20);
            this.EmailText.TabIndex = 38;
            // 
            // ContactText
            // 
            this.ContactText.Location = new System.Drawing.Point(248, 95);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(200, 20);
            this.ContactText.TabIndex = 37;
            // 
            // SecondNameText
            // 
            this.SecondNameText.Location = new System.Drawing.Point(248, 56);
            this.SecondNameText.Name = "SecondNameText";
            this.SecondNameText.Size = new System.Drawing.Size(200, 20);
            this.SecondNameText.TabIndex = 36;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(248, 14);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(200, 20);
            this.FirstNameText.TabIndex = 35;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(76, 234);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(66, 16);
            this.Gender.TabIndex = 34;
            this.Gender.Text = "Gender :";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.Location = new System.Drawing.Point(77, 186);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(102, 16);
            this.DateOfBirth.TabIndex = 33;
            this.DateOfBirth.Text = "Date Of Birth :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(77, 143);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 16);
            this.Email.TabIndex = 32;
            this.Email.Text = "Email :";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(77, 99);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(67, 16);
            this.Contact.TabIndex = 31;
            this.Contact.Text = "Contact :";
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondName.Location = new System.Drawing.Point(76, 60);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(113, 16);
            this.SecondName.TabIndex = 30;
            this.SecondName.Text = "Second Name :";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(76, 18);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(90, 16);
            this.FirstName.TabIndex = 29;
            this.FirstName.Text = "First Name :";
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.Location = new System.Drawing.Point(76, 278);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(98, 16);
            this.designation.TabIndex = 41;
            this.designation.Text = "Designation :";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(77, 325);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(58, 16);
            this.Salary.TabIndex = 44;
            this.Salary.Text = "salary :";
            // 
            // salarytext
            // 
            this.salarytext.Location = new System.Drawing.Point(248, 321);
            this.salarytext.Name = "salarytext";
            this.salarytext.Size = new System.Drawing.Size(200, 20);
            this.salarytext.TabIndex = 45;
            // 
            // designationbox
            // 
            this.designationbox.FormattingEnabled = true;
            this.designationbox.Location = new System.Drawing.Point(248, 273);
            this.designationbox.Name = "designationbox";
            this.designationbox.Size = new System.Drawing.Size(200, 21);
            this.designationbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designationbox.TabIndex = 46;
            // 
            // AddAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.designationbox);
            this.Controls.Add(this.salarytext);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.designation);
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
            this.Name = "AddAdvisor";
            this.Text = "AddAdvisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
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
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.TextBox salarytext;
        private System.Windows.Forms.ComboBox designationbox;
    }
}