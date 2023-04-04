using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject.Component
{
    public partial class EvaluateGroup : Form
    {

        string FormType = "Add";
        int addReference = 0;

        public EvaluateGroup(int index, string type)
        {
            this.FormType = type;
            this.addReference = index;
            InitializeComponent();
            GetGroupID();
            EvaluationName();
            if(FormType == "Update")
            {
                GetData(index);
            }
        }
        public void GetGroupID()
        {
            int n = getStatus("Active");
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select GroupId from GroupStudent where Status = @status Group by(GroupId)", con);
            cmd.Parameters.AddWithValue("@status", n);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["GroupId"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            GroupIDText.DataSource = dataList;
        }

        public void EvaluationName()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select Name from Evaluation ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Name"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            EvaluationNameText.DataSource = dataList;
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

        public void GetData(int index)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select GroupId,EvaluationId,ObtainedMarks,EvaluationDate From GroupEvaluation where Id =@index ", con);
            cmd.Parameters.AddWithValue("@Index", index);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                GroupIDText.Text = reader["GroupId"].ToString();
                String m  = reader["EvaluationId"].ToString();
                ObtainMarksText.Text = reader["ObatinMarks"].ToString();
                EvaluationDateText.Text = reader["evaluationDate"].ToString();
                reader.Close();
                string z = GetEvaluationId(m);
                EvaluationNameText.Text = z;
                //GenderBox.Text = GetStringGender(Gender);
            }
            else
            {
                MessageBox.Show("notthing");
            }
            con.Close();
            reader.Close();

        }

        public string GetEvaluationId( string value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT Name FROM Evaluation WHERE Id = @Enter";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            String StringValue = reader["Name"].ToString();
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            reader.Close();
            con.Close();
            return StringValue;
        }

        private void EvaluateGroup_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(validation.CheckObtainMarks(ObtainMarksText.Text))
            {
                int totalMarks = EvaluationTotal(EvaluationNameText.Text);
                if (int.Parse(ObtainMarksText.Text) < totalMarks)
                {
                    StoreData();
                }
                else
                {
                    MessageBox.Show("Obtain marks be less then" + totalMarks.ToString());
                }
                
            }
        }

        public int EvaluationTotal(String name)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT TotalMarks FROM Evaluation WHERE Name = @Enter";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", name);
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

        public void StoreData()
        {
            if (FormType == "Add")
            {
                writedata();
            }
            else if (FormType == "Update")
            {
                updatedata();
            }
        }

        public void writedata()
        {
            int m = evaluationId(EvaluationNameText.Text);
            //int Gender = GetGender(GenderBox.Text);
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //DateTime dob = Convert.ToDateTime(DateOfBirthText.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate ) " +
                "VALUES (@groupid, @evaluationid, @obtainedmarks,@evaluationdate)", con);
            cmd.Parameters.AddWithValue("@groupid", GroupIDText.Text);
            cmd.Parameters.AddWithValue("@evaluationid", m);
            cmd.Parameters.AddWithValue("@obtainedmarks", ObtainMarksText.Text);
            cmd.Parameters.AddWithValue("@evaluationdate",EvaluationDateText.Text);

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

        public int evaluationId(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT Id FROM Evaluation WHERE Name = @Enter";
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

        public void updatedata()
        {
            int m = evaluationId(EvaluationNameText.Text);
            //MessageBox.Show(Gender.ToString());
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Update GroupEvaluation Set GroupId = @firstname, EvaluationId = @lastname, ObtainedMarks = @contact,EvaluationIdDate = @hello where Id  = @addreference", con);
            cmd.Parameters.AddWithValue("@firstname", (GroupIDText.Text));
            cmd.Parameters.AddWithValue("@lastname", m);
            cmd.Parameters.AddWithValue("@contact", int.Parse(ObtainMarksText.Text));
            cmd.Parameters.AddWithValue("@hello", (EvaluationDateText.Text).ToString());
            cmd.Parameters.AddWithValue("addreference", addReference);
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
    }
}
