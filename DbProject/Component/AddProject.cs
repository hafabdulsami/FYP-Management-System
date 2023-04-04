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
    public partial class AddProject : Form
    {
        string FormType = "Add";
        int addReference = 0;
        public AddProject(string type, int index)
        {
            InitializeComponent();
            this.FormType = type;
            this.addReference = index;
            AdvisorBoxValue();
            AdvisorRoleBoxValue();
            MessageBox.Show(FormType);
            if (type == "Update")
            {
                GetData(index);
            }
        }

        public void GetData(int index)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select t1.Title ,t1.Description , t2.AdvisorRole , t2.AssignmentDate ,t3.Email From Project t1 join ProjectAdvisor t2 on t1.id  = t2.Projectid join Person t3 on AdvisorId = t3.Id", con);
            cmd.Parameters.AddWithValue("@Index", index);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                titleText.Text = reader["Title"].ToString();
                descriptionText.Text = reader["Description"].ToString();
                AssigmentdateText.Text = reader["AssignmentDate"].ToString();
                AdvisorRolebox.Text = reader["AdvisorRole"].ToString();
                AdvisorBox.Text = reader["Email"].ToString();
                //DateOfBirthText.Text = reader["DateOfBirth"].ToString();
                reader.Close();
      
            }
            else
            {
                MessageBox.Show("notthing");
            }
            con.Close();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (TitleExist(titleText.Text))
            {
                addData();
            }
            else
            {
                MessageBox.Show("Already Exist");
            }
        }

        public void AdvisorBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Email from Advisor AS t1 , Person AS t2 where t1.Id = t2.Id ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                string name = reader["Email"].ToString();
                //name = name + reader["LastName"].ToString();
                // Add data to list
                dataList.Add(name);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            AdvisorBox.DataSource = dataList;
        }

        public void AdvisorRoleBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'ADVISOR_ROLE'", con);
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
            AdvisorRolebox.DataSource = dataList;
        }

        public bool TitleExist(String value)
        {
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(Title) from Project where Title = @title", con);
            cmd.Parameters.AddWithValue("@title", value);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               // MessageBox.Show("hello");
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


        public void WriteData()
        {
            int Advisor = GetAdvisor(AdvisorBox.Text);
            int AdvisorRole = GetAdvisorRole(AdvisorRolebox.Text);
            //MessageBox.Show("hello");
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                //MessageBox.Show("open");
                con.Open();
            }
            DateTime dob = Convert.ToDateTime(AssigmentdateText.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO Project (Description, Title) " +
                "OUTPUT INSERTED.ID " +
                "VALUES (@description, @title)", con);
            cmd.Parameters.AddWithValue("@description", descriptionText.Text);
            cmd.Parameters.AddWithValue("@title", titleText.Text);
           // cmd.ExecuteNonQuery();
            int insertedProjectID = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO ProjectAdvisor (AdvisorId,ProjectId,AdvisorRole,AssignmentDate) " +
                "VALUES (@advisorid, @projectid,@advisorrole,@assigmentdate)", con);

            cmd.Parameters.AddWithValue("@advisorid", Advisor);
            cmd.Parameters.AddWithValue("@projectid", insertedProjectID);
            cmd.Parameters.AddWithValue("@advisorrole", AdvisorRole);
            cmd.Parameters.AddWithValue("@assigmentdate", dob);
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("hello");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();

            }
        }

        public int GetAdvisor(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Person WHERE Email = @Enter ";
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

        public int GetAdvisorRole(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter ";
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

        public void UpdateData()
        {
            int Advisor = GetAdvisor(AdvisorBox.Text);
            int AdvisorRole = GetAdvisorRole(AdvisorRolebox.Text);
            //MessageBox.Show("hello");
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                //MessageBox.Show("open");
                con.Open();
            }
            DateTime dob = Convert.ToDateTime(AssigmentdateText.Text);
            SqlCommand cmd = new SqlCommand("Update Project Set Title = @title , Description = @description where Id  = @addreference", con);
            cmd.Parameters.AddWithValue("@title", titleText.Text);
            cmd.Parameters.AddWithValue("@description", descriptionText.Text);
            cmd.Parameters.AddWithValue("@addreference", addReference);
            cmd.ExecuteNonQuery();
            //int insertedProjectID = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("Update ProjectAdvisor set AdvisorId = @advisorid, AdvisorRole = @advisorrole, AssignmentDate = @assigmentdate  where ProjectId = @projectid ", con);

            cmd.Parameters.AddWithValue("@advisorid", Advisor);
            cmd.Parameters.AddWithValue("@projectid", addReference);
            cmd.Parameters.AddWithValue("@advisorrole", AdvisorRole);
            cmd.Parameters.AddWithValue("@assigmentdate", dob);
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
    }
}
