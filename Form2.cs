using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_DATABASE_MANAGEMENT_SYSTEM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u= "username", p= "password", c1, c2;
            c1 = textBox1.Text;
            c2 = textBox2.Text;
            if (u.Equals(c1) && p.Equals(c2))
            {


                Form3 obj = new Form3();
                this.Hide();
                obj.Show();
            }
            else
            {
                label2.Show();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
