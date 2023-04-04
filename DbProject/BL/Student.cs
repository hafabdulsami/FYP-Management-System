using DbProject.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DbProject.BL
{
    internal class Student
    {
        public Student() { }
        public Student(string firstName, string lastName, string contact, string email, DateTime dateOfBirth, string gender, string regNo)
        {
            FirstName = firstName;
            LastName = lastName;
            Contact = contact;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            RegNo = regNo;
        }

        private String FirstName = null;
        private String LastName = null;
        private String Contact = null;
        private String Email = null;
        private DateTime DateOfBirth;
        private String Gender = null;
        private String RegNo = null;
        //private int GenderInInt = 0;

        public bool CheckValidation()
        {
            if(validation.CheckFirstName(FirstName) && validation.CheckSecondName(LastName) && validation.CheckContact(Contact) && validation.CheckEmail(Email) && validation.CheckGender(Gender) && validation.CheckRegNo(RegNo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void WriteInDataBase()
        {
            try 
            {
                int GenderInInt = GetGender(Gender);
                var con = Configuration.getInstance().getConnection();
                con.Open();
                string sql = "Insert into Person values (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Contact", Contact);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", GenderInInt);

                    // Get the auto-generated order_id value
                    int orderId = Convert.ToInt32(command.ExecuteScalar());

                    // Insert one or more order items into the order_items table
                    sql = "Insert into Student values(@Id,@RegistrationNo)";
                    using (SqlCommand command2 = new SqlCommand(sql, con))
                    {
                        command2.Parameters.AddWithValue("@Id", orderId);
                        command2.Parameters.AddWithValue("@RegistrationNo", RegNo);
                        command2.ExecuteNonQuery();
                    }
                }

            } // MessageBox.Show("kell");
            catch
            {
                MessageBox.Show("Data is not store due to poor connection");
            }

        }
        public String CheckValueInDataBase()
        {
            String Status = null;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select RegistrationNo from Student ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                
                // Retrieve data from reader
                object data = reader["RegistrationNo"];
                if(data.ToString()  == RegNo)
                {
                    Status = "RegistrationNo";
                }
                // Add data to list
                //dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select Email from Person ", con);
            SqlDataReader reader1 = cmd.ExecuteReader();
            // Create list to store retrieved data
            //List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data1 = reader["Email"];
                if(Status == null && data1.ToString() == Email)
                {
                    Status = "Email";
                }
                else if(Status != null && data1.ToString() == Email)
                {
                    Status = Status + "Email";
                }
                // Add data to list
                //dataList.Add(data);
            }
            // Close reader and connection
            reader1.Close();
            con1.Close();
            return Status;
        }

        public int GetGender( string Value)
        {
            var con = Configuration.getInstance().getConnection();
            con.Open();
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

    }
}
