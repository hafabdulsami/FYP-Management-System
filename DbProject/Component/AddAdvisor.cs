using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject.Component
{
    public partial class AddAdvisor : Form
    {
        string FormType = "Add";
        int addReference = 0;

        public AddAdvisor(int index, string type)
        {
            this.FormType = type;
            this.addReference = index;
            InitializeComponent();
            GenderBoxValue();
            designationBoxValue();
            MessageBox.Show(FormType);
            if (type == "Update")
            {
                GetData(index);
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
            con.Close();
            return intValue;
        }

        public int GetDesignation(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'Designation'";
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
            con.Close();
            return intValue;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (validation.CheckFirstName(FirstNameText.Text) && validation.CheckSecondName(SecondNameText.Text) && validation.CheckContact(ContactText.Text) && validation.CheckEmail(EmailText.Text) && validation.CheckGender(GenderBox.Text) && validation.CheckDesignation(designationbox.Text) && validation.CheckSalary(salarytext.Text))
            {
                if (EmailExist(EmailText.Text))
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
                MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                MessageBox.Show(count.ToString());
                if (count == 0 || (FormType == "Update" && count == 1))
                {
                        MessageBox.Show("loo");
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
            if (FormType == "Add")
            {
                WriteData();
                
            }
            else if (FormType == "Update")
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
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select FirstName,LastName ,Contact,Email,DateOfBirth,Gender,Salary,Designation From Person AS t1 ,Advisor AS T2 where t2.Id = @Index and t1.Id = @Index ", con);
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
                salarytext.Text = reader["Salary"].ToString();
                String Gender = reader["Gender"].ToString();
                string Designation = reader["Designation"].ToString();
                reader.Close();
                GenderBox.Text = GetStringGender(Gender);
                designationbox.Text = GetstringDesignation(Designation);
            }
            else
            {
                MessageBox.Show("notthing");
            }

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

        public string GetstringDesignation(string value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT Value FROM Lookup WHERE Id = @Enter And  Category = 'Designation'";
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
            int Designationno = GetDesignation(designationbox.Text);
            //MessageBox.Show("hello");
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                //MessageBox.Show("open");
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
            cmd.ExecuteNonQuery();
            int insertedPersonID = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Advisor (Designation,Salary,ID) " +
                "VALUES (@designation, @salary,@ID)", con);
            cmd.Parameters.AddWithValue("@designation", Designationno);
            cmd.Parameters.AddWithValue("@salary",int.Parse(salarytext.Text));
            cmd.Parameters.AddWithValue("@ID", insertedPersonID);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("hello");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();

            }
        }

        public void UpdateData()
        {
            DateTime date = Convert.ToDateTime(DateOfBirthText.Text);
            int Gender = GetGender(GenderBox.Text);
            int Designation = GetDesignation(designationbox.Text);
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
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
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@addreference", addReference);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("UPDATE Advisor Set Designation = @des,Salary = @salary where Id = @reference",con);
            MessageBox.Show("3");
            cmd.Parameters.AddWithValue("@reference", addReference);
            MessageBox.Show("2");
            cmd.Parameters.AddWithValue("@des", Designation);
            MessageBox.Show("1");
            cmd.Parameters.AddWithValue("@salary", int.Parse(salarytext.Text));
            //cmd.Parameters.AddWithValue("@regno", (RegNoText.Text));
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("hello");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();

            }
            this.Close();
        }

        public void designationBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'DESIGNATION'", con);
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
            designationbox.DataSource = dataList;
        }

    }
}
