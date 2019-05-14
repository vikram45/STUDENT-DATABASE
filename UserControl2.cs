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
    public partial class UserControl2 : UserControl
    {
        private static UserControl2 _instance;
        public static UserControl2 Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl2();
                }
                return _instance;

            }
        }
        public UserControl2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");


        

        public void refreshgrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Show_department_SF", con);
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
            SqlCommand cmd = new SqlCommand("Add_Department_SF", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Department_Name", textBox5.Text);
            cmd.Parameters.AddWithValue("@Building", textBox12.Text);
            cmd.Parameters.AddWithValue("@Budget", textBox11.Text);
           
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
                SqlCommand cmd = new SqlCommand("Delete_Student_SP", con);
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

            textBox5.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
           
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            refreshgrid();
        }
    }
}
