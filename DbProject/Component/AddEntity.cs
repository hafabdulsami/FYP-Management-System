using DbProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DbProject.Component
{
    public partial class AddEntity : Form
    {
        string FormType = "Add";
        int addReference = 0;
        public AddEntity(int index , string type)
        {
            this.FormType = type;
            this.addReference = index;
            InitializeComponent();
            GenderBoxValue();

            if(type == "Update")
            {
               GetData(index);
            }
        }
       

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (validation.CheckFirstName(FirstNameText.Text) && validation.CheckSecondName(SecondNameText.Text) && validation.CheckContact(ContactText.Text) && validation.CheckEmail(EmailText.Text) && validation.CheckGender(GenderBox.Text) && validation.CheckRegNo(RegNoText.Text))
            {
                if( RegExist(RegNoText.Text) && EmailExist(EmailText.Text))
                {
                    addData();
                }
                else
                {
                 
                    MessageBox.Show("Already Exist");
                }
                
            }
            else
            {
                MessageBox.Show("Data is In Wrong Format");
            }
        }

        public int GetGender(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'GENDER'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", Value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            reader.Close();
            con.Close();
            return intValue;
        }


        public bool RegExist(String value)
        {
            bool Status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select count(RegistrationNo) from Student where RegistrationNo = @regno", con);
            cmd.Parameters.AddWithValue("@regno",value);
            SqlDataReader reader = cmd.ExecuteReader();
            //reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int count  = reader.GetInt32(0);
                if(count == 0 || (FormType == "Update" && count == 1))
                {
                   // MessageBox.Show("loo");
                    Status =  true ;
                }
                   // MessageBox.Show("HH");
            }
            
            // Close reader and connection
            reader.Close();
            con.Close();
            return Status;
        }

        public bool EmailExist(String value)
        {
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(Email) from Person where Email = @ema", con);
            cmd.Parameters.AddWithValue("@ema", value);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                if (count == 0 || (FormType == "Update" && count == 1))
                {
               //     MessageBox.Show("loo");
                    status = true;
                }
             //   MessageBox.Show("HH");
            }
            // Create list to store retrieved data

            // Close reader and connection
            reader.Close();
            con.Close();
            return status;
        }

        public void addData()
        {
            if(FormType == "Add")
            {
                WriteData();
            }
            else if(FormType == "Update")
            {
                UpdateData();
            }

            

        }

        public void GenderBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'GENDER'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Value"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            GenderBox.DataSource = dataList;
        }

        public void GetData(int index)
        {
            var con = Configuration.getInstance().getConnection();
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
            SqlCommand cmd = new SqlCommand("Select FirstName,LastName ,Contact,Email,DateOfBirth,Gender,RegistrationNo From Person AS t1 ,Student AS T2 where t2.Id = @Index and t1.Id = @Index", con );
            cmd.Parameters.AddWithValue("@Index", index);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                FirstNameText.Text = reader["FirstName"].ToString();
                SecondNameText.Text = reader["LastName"].ToString();
                ContactText.Text = reader["Contact"].ToString();
                EmailText.Text = reader["Email"].ToString();
                DateOfBirthText.Text = reader["DateOfBirth"].ToString();
                //DateOfBirthText.Text = reader["DateOfBirth"].ToString();
                RegNoText.Text = reader["RegistrationNo"].ToString();
                string Gender = reader["Gender"].ToString();
                reader.Close();
                GenderBox.Text = GetStringGender(Gender);
            }
            else
            {
                MessageBox.Show("Data Doesnot Exist...");
            }
            con.Close() ;
            
        }
        
        public string GetStringGender(string value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT Value FROM Lookup WHERE Id = @Enter And  Category = 'GENDER'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            String StringValue = reader["Value"].ToString();
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            reader.Close();
            con.Close();
            return StringValue;
        }

        public void WriteData()
        {
            int Gender = GetGender(GenderBox.Text);
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime dob = Convert.ToDateTime(DateOfBirthText.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) " +
                "OUTPUT INSERTED.ID " +
                "VALUES (@FirstName, @LastName, @Contact, @Email, @DOB, @Gender)", con);
            cmd.Parameters.AddWithValue("@FirstName", FirstNameText.Text);
            cmd.Parameters.AddWithValue("@LastName", SecondNameText.Text);
            cmd.Parameters.AddWithValue("@Contact", ContactText.Text);
            cmd.Parameters.AddWithValue("@Email", EmailText.Text);
            cmd.Parameters.AddWithValue("@DOB", dob);
            cmd.Parameters.AddWithValue("@Gender", Gender);

            int insertedPersonID = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Student (RegistrationNo, ID) " +
                "VALUES (@RegistrationNo, @ID)", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", RegNoText.Text);
            cmd.Parameters.AddWithValue("@ID", insertedPersonID);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            this.Close();
        }

        public void UpdateData()
        {
            DateTime date  = Convert.ToDateTime(DateOfBirthText.Text);
            int Gender = GetGender(GenderBox.Text);
            //MessageBox.Show(Gender.ToString());
            SqlConnection con = Configuration.getInstance().getConnection();
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Update Person Set FirstName = @firstname, LastName = @lastname, Contact = @contact, Email = @email, DateOfBirth = @dateofbirth, Gender = @gender where Id  = @addreference", con);
            cmd.Parameters.AddWithValue("@firstname", (FirstNameText.Text));
            cmd.Parameters.AddWithValue("@lastname", (SecondNameText.Text));
            cmd.Parameters.AddWithValue("@contact", (ContactText.Text));
            cmd.Parameters.AddWithValue("@email", (EmailText.Text));
            cmd.Parameters.AddWithValue("@dateofbirth", (date));
            //cmd.Parameters.AddWithValue("@firstname", (FirstNameText.Text));
            cmd.Parameters.AddWithValue("@gender",Gender);
            cmd.Parameters.AddWithValue("@addreference", addReference);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("UPDATE Student Set RegistrationNo = @regno where Id = @reference",con);
            cmd.Parameters.AddWithValue("@reference", addReference);
            cmd.Parameters.AddWithValue("@regno", (RegNoText.Text));
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                this.Close();

            }
        }

        private void AddEntity_Load(object sender, EventArgs e)
        {

        }
    }
}
