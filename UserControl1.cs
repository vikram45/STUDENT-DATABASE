using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace STUDENT_DATABASE_MANAGEMENT_SYSTEM
{
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _instance;
        public static UserControl1 Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl1();
                }
                return _instance;

            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");


        private void UserControl1_Load(object sender, EventArgs e)
        {
            refreshgrid();
        }

        public void refreshgrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowStudentData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                       INVALID SQL OPERATION \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("                       INVALID SQL OPERATION \n" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("StudentAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Student_ID", textBox5.Text);
            cmd.Parameters.AddWithValue("@First_Name", textBox12.Text);
            cmd.Parameters.AddWithValue("@Last_Name", textBox11.Text);
            cmd.Parameters.AddWithValue("@Sex", textBox10.Text);
            cmd.Parameters.AddWithValue("@Department", textBox9.Text);
            cmd.Parameters.AddWithValue("@Institute", textBox8.Text);
            cmd.Parameters.AddWithValue("@Total_Credit", textBox7.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", textBox6.Text);
            cmd.Parameters.AddWithValue("@Email_ID", textBox2.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("   Error \n" + ex);
            }
            con.Close();
            refreshgrid();
        }
        public void delete()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("DeleteStudent_Sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Student_ID", textBox5.Text);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                       INVALID SQL OPERATION \n" + ex);
                }
                con.Close();

                refreshgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("                       INVALID SQL OPERATION \n" + ex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        textBox5.Text= "";
           textBox12.Text= "";
          textBox11.Text = "";
         textBox10.Text = "";
         textBox9.Text = "";
       textBox8.Text = "";
       textBox7.Text = "";
         textBox6.Text = "";
     textBox2.Text ="";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
