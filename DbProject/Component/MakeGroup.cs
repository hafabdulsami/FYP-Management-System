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
    public partial class MakeGroup : Form
    {
        string FormType = "Add";
        int addReference = 0;

        public MakeGroup(string Type , int Reference )
        {
            this.FormType = Type;
            this.addReference = Reference;
            InitializeComponent();
            AddStatus();
            AddProject();
           

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (validation.CheckRegNo(StudentRegText.Text.ToString()))
            {
                if (ProjectExist(ProjectText.Text.ToString()) && StudentExist(StudentRegText.Text.ToString()) && availableStudent(StudentRegText.Text.ToString()) && availableProject(ProjectText.Text))
                {
                    addData();
                }
                else
                {
                    MessageBox.Show("already exist");
                }
            }
            else
            {
                MessageBox.Show(StudentRegText.ToString());
                MessageBox.Show("no");
            }
        }


        public bool ProjectExist(String value)
        {
            int ProjectId = getProjectId(value);
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(ProjectId) from GroupProject where ProjectId = @projectid", con);
            cmd.Parameters.AddWithValue("@projectid", ProjectId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                if (count == 0 || (FormType == "Update" && count == 1))
                {
                    //MessageBox.Show("loo");
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

        public bool StudentExist(String value)
        {
            bool status = false;
             //status = availableStudent(StudentID(value));
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(RegistrationNo)  from Student where RegistrationNo = @registrationid", con);
            cmd.Parameters.AddWithValue("@registrationid", value);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
               // MessageBox.Show(reader.GetInt32(1).ToString());
                MessageBox.Show(count.ToString());
                if (count == 1 )
                {
                    //MessageBox.Show("loo");
                    status = true;
                }
                else
                {
                    MessageBox.Show("doesnot exist");
                }
                //   MessageBox.Show("HH");
            }
            // Create list to store retrieved data

            // Close reader and connection
            reader.Close();
            con.Close();

            return status;
        }

        public int StudentID(string value)
        {
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id from Student where RegistrationNo = @registrationid", con);
            cmd.Parameters.AddWithValue("@registrationid", value);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                count = reader.GetInt32(0);
                MessageBox.Show(count.ToString());
                if (count == 1 )
                {
                    //MessageBox.Show("loo");
                    status = true;
                }
                else
                {
                    MessageBox.Show("doesnot exist2");
                }
                //   MessageBox.Show("HH");
            }
            // Create list to store retrieved data

            // Close reader and connection
            reader.Close();
            con.Close();

            //status = availableStudent();
            return count;
        }

        public void AddStatus()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'STATUS'", con);
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
            StatusText.DataSource = dataList;
        }

        public void AddProject()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Title from Project ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Title"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            ProjectText.DataSource = dataList;
        }

        public bool availableProject(string projectName)
        {
            int m = getProjectId(projectName);
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(ProjectId) from GroupProject where ProjectId = @studentid", con);
            cmd.Parameters.AddWithValue("@studentid", m);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                if (count == 0 || (FormType == "Update" && count == 1))
                {
                    //MessageBox.Show("loo");
                    status = true;
                }
                else
                {
                    MessageBox.Show("Not available");
                }
                //   MessageBox.Show("HH");
            }
            // Create list to store retrieved data

            // Close reader and connection
            reader.Close();
            con.Close();
            return status;
        }
        public bool availableStudent(string reg)
        {
            //int ProjectId = getProjectId(value);
            int m = StudentID(reg);
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(StudentId) from GroupStudent where StudentId = @studentid", con);
            cmd.Parameters.AddWithValue("@studentid", m);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                if (count == 0 || (FormType == "Update" && count == 1))
                {
                    //MessageBox.Show("loo");
                    status = true;
                }
                else
                {
                    MessageBox.Show("Not available");
                }
                //   MessageBox.Show("HH");
            }
            // Create list to store retrieved data

            // Close reader and connection
            reader.Close();
            con.Close();
            return status;
        }

        
        public int getProjectId(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Project WHERE Title = @Enter ";
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

        public void addData()
        {
            if (FormType == "Add")
            {
                WriteData();
            }
            else if (FormType == "Update")
            {
                UpdateData();
                StudentRegText.ReadOnly = true;
            }



        }

        public void WriteData()
        {
            int ProjectNo = getProjectId(ProjectText.Text);
            int Studentid = StudentID(StudentRegText.Text);
            int status = getStatus(StatusText.Text);
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime dob = Convert.ToDateTime(CreatedOnText1.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO [Group] (Created_On) " +
                "OUTPUT INSERTED.ID " +
                "VALUES (@createdon)", con);
            cmd.Parameters.AddWithValue("@createdon", dob);
            
            int insertedGroupID = (int)cmd.ExecuteScalar();

            

            cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId,StudentId , Status,AssignmentDate)" + 
                "VALUES(@groupid,@studentid,@status,@assignmentdate)",con);
            cmd.Parameters.AddWithValue("@groupid", insertedGroupID);
            cmd.Parameters.AddWithValue("@studentid", Studentid);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@assignmentdate", dob);

            try
            {
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO GroupProject (ProjectId,GroupId,AssignmentDate) " +
                "VALUES (@projectid,@groupid, @assignmentdate)", con);
                cmd.Parameters.AddWithValue("@projectid", ProjectNo);
                cmd.Parameters.AddWithValue("@groupid", insertedGroupID);
                cmd.Parameters.AddWithValue("@assignmentdate", dob);
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

        }

        public int getStatus(String value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'STATUS'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", value);
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



    }
}

    

