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
    public partial class AddEvaluation : Form
    {

        string FormType = "Add";
        int addReference = 0;

        public AddEvaluation(int index, string type)
        {
            this.FormType = type;
            this.addReference = index;
            InitializeComponent();
            if (type == "Update")
            {
                GetData(index);
            }
        }


        public void  GetData(int index)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select Name,TotalMarks,TotalWeightage From Evaluation where Id =@index ", con);
            cmd.Parameters.AddWithValue("@Index", index);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                NameText.Text = reader["Name"].ToString();
                TotalMarksText.Text = reader["TotalMarks"].ToString();
                TotalWeightageText.Text = reader["TotalWeightage"].ToString();
                //GenderBox.Text = GetStringGender(Gender);
            }
            else
            {
                MessageBox.Show("notthing");
            }
            con.Close();
            reader.Close();
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validation.CheckFirstName(NameText.Text).ToString() + validation.CheckMarks(TotalMarksText.Text).ToString() + validation.Checkweightage(TotalWeightageText.Text).ToString());
            if(validation.CheckFirstName(NameText.Text) && validation.CheckMarks(TotalMarksText.Text) && validation.Checkweightage(TotalWeightageText.Text) )
            {
                if (NameExist(NameText.Text))
                {
                    Adddata();
                }
            }
            else
            {
                MessageBox.Show("data is not in correct format");
            }
        }

        public bool NameExist(String value)
        {
            bool Status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select count(Name) from Evaluation where Name = @name", con);
            cmd.Parameters.AddWithValue("@name", value);
            SqlDataReader reader = cmd.ExecuteReader();
            //reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                if (count == 0 || (FormType == "Update" && count == 1))
                {
                    // MessageBox.Show("loo");
                    Status = true;
                }
                // MessageBox.Show("HH");
            }

            // Close reader and connection
            reader.Close();
            con.Close();
            return Status;
        }

        public void Adddata()
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
            //int Gender = GetGender(GenderBox.Text);
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //DateTime dob = Convert.ToDateTime(DateOfBirthText.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage ) " +
                "OUTPUT INSERTED.ID " +
                "VALUES (@name, @totalmarks, @totalweightage)", con);
            cmd.Parameters.AddWithValue("@name", NameText.Text);
            cmd.Parameters.AddWithValue("@totalmarks", TotalMarksText.Text);
            cmd.Parameters.AddWithValue("@totalweightage", TotalWeightageText.Text);
            
           

           
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

        public void updatedata()
        {
            
            //MessageBox.Show(Gender.ToString());
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Update Evaluation Set Name = @firstname, TotalMarks = @lastname, TotalWeightage = @contact where Id  = @addreference", con);
            cmd.Parameters.AddWithValue("@firstname", (NameText.Text));
            cmd.Parameters.AddWithValue("@lastname", int.Parse(TotalMarksText.Text));
            cmd.Parameters.AddWithValue("@contact", int.Parse(TotalWeightageText.Text));
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
