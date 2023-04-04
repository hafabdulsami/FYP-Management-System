using DbProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbProject.Component
{
    public partial class AddEdit : Form
    {
        String FormType = "Add";
        public AddEdit(string type)
        {
            this.FormType = type;
            InitializeComponent();
            AddProject();
            AddStatus();
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
                string name = reader["Title"].ToString();
                //name = name + reader["LastName"].ToString();
                // Add data to list
                dataList.Add(name);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            ProjectText.DataSource = dataList;
        }

        private void projectConfirm_Click(object sender, EventArgs e)
        {
            if(FormType == "Add")
            {
                GetStudent();
            }
            else if( FormType == "Update")
            {
                GetSomeStudent();
            }
           
            
        }

        public void GetSomeStudent()
        {
            //int value = GetProjectId(ProjectText.Text);
            int group = GetGroupId();
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select t1.RegistrationNo from Student t1 Join GroupStudent t2 on t1.Id = t2.StudentId where t2.GroupId = @value", con);
            //cmd.Parameters.AddWithValue("@RegistrationNo", value);
            cmd.Parameters.AddWithValue("@value",group);
            //cmd.Parameters.AddWithValue("@status", status);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                string name = reader["RegistrationNo"].ToString();
                //name = name + reader["LastName"].ToString();
                // Add data to list
                dataList.Add(name);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            studenttext.DataSource = dataList;
        }

        public void GetStudent()
        {
            //int status = GetStatus();
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select RegistrationNo from Student ", con);
            //cmd.Parameters.AddWithValue("@status", status);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                string name = reader["RegistrationNo"].ToString();
                //name = name + reader["LastName"].ToString();
                // Add data to list
                dataList.Add(name);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            studenttext.DataSource = dataList;
        }

        public int GetStatus(string status)
        {
            int Id = 0;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id from Lookup where Category = 'STATUS' AND Value = @status ", con);
            cmd.Parameters.AddWithValue("@status", status);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            if (reader.Read())
            {
                Id = reader.GetInt32(0);

            }
            // Close reader and connection
            reader.Close();
            con.Close();
            return Id;

        }

        public int GetProjectId(String value)
        {
            int Id = 0;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id from Project where Title = @title", con);
            cmd.Parameters.AddWithValue ("@title", value);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            if (reader.Read())
            {
                Id = reader.GetInt32(0);
                
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            return Id;
            //ProjectText.DataSource = dataList;
        }

        private void StudentConfirm_Click(object sender, EventArgs e)
        {
            if(StudentAvailable()) 
            {
                MessageBox.Show("Student is available");
            }
            if(FormType == "Update")
            {
                StatusText.AllowDrop = true;
            }
        }

        public bool StudentAvailable()
        {
            int index  = getStudentID(studenttext.Text);
            int Status = GetStatus("active");
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(StudentId) from GroupStudent where StudentId = @studentid and Status = @status", con);
            cmd.Parameters.AddWithValue("@studentid", index);
            cmd.Parameters.AddWithValue("@status", Status);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                MessageBox.Show(count.ToString());
                if (count == 0 )
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

        public int getStudentID(string value)
        {
            int Id = 0;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id from Student where RegistrationNo = @value", con);
            cmd.Parameters.AddWithValue ("@value", value);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            if (reader.Read())
            {
                Id = reader.GetInt32(0);

            }
            // Close reader and connection
            reader.Close();
            con.Close();
            return Id;
        }


        public void AddStudent()
        {
            int groupid  = GetGroupId();
            int studentid = getStudentID(studenttext.Text);
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId,StudentId , Status,AssignmentDate)" +
                "VALUES(@groupid,@studentid,@status,@assignmentdate)", con);
            cmd.Parameters.AddWithValue("@groupid", groupid);
            cmd.Parameters.AddWithValue("@studentid", studentid);
            cmd.Parameters.AddWithValue("@status", StatusText.Text.ToString());
            cmd.Parameters.AddWithValue("@assignmentdate", formattedDateTime);
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

        }

        public int GetGroupId()
        {
            int ProjectID = GetProjectId(ProjectText.Text);
            int Id = 0 ;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select GroupId from GroupProject where ProjectId =@projectid ", con);
            cmd.Parameters.AddWithValue("@projectid", ProjectID);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            if (reader.Read())
            {
                Id = reader.GetInt32(0);

            }
            // Close reader and connection
            reader.Close();
            con.Close();
            return Id;

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(FormType == "Add" && (ProjectText.Text.Length != 0) && (studenttext.Text.Length != 0) && (StatusText.Text.Length != 0))
            {
                if ((TotalQuantity()))
                {
                    AddStudent();
                }
                else
                {
                    MessageBox.Show("Group is full");
                }
            }
            else if(FormType == "Update" && (ProjectText.Text.Length != 0) && (studenttext.Text.Length != 0) && (StatusText.Text.Length != 0))
            {
                UpdateStudent();
            }
            else
            {
                MessageBox.Show("please fill all colmun");
            }
            
        }

        public void UpdateStudent()
        {
            int value = getStudentID(studenttext.Text);
            int status = getIntstatus(StatusText.Text);
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("UPDATE GroupStudent Set Status = '@status' where StudentId = @value",con);
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@status", status);
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

        }

        public int getIntstatus(string text)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'STATUS'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", text);
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

        public bool TotalQuantity()
        {
            int groupid = GetGroupId();
            int Status = getIntstatus("Active");
            bool status = false;
            int index = 0;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(StudentId) from GroupStudent where GroupId = @groupid and Status = @status", con);
            cmd.Parameters.AddWithValue("@groupid", groupid);
            cmd.Parameters.AddWithValue("@status", Status);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                MessageBox.Show(count.ToString());
                if (count < 4)
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
    }
}
