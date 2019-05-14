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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!panel7.Controls.Contains(UserControl1.Instance))
            {
                panel7.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();

            }
            else
            {
                UserControl1.Instance.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Width <= 75)
                panel2.Width = 300;
            else
                panel2.Width = 75;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl4.Instance))
            {
                panel7.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();

            }
            else
            {
                UserControl4.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!panel7.Controls.Contains(UserControl2.Instance))
            {
                panel7.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();

            }
            else
            {
                UserControl2.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl3.Instance))
            {
                panel7.Controls.Add(UserControl3.Instance);
                UserControl3.Instance.Dock = DockStyle.Fill;
                UserControl3.Instance.BringToFront();

            }
            else
            {
                UserControl3.Instance.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl5.Instance))
            {
                panel7.Controls.Add(UserControl5.Instance);
                UserControl5.Instance.Dock = DockStyle.Fill;
                UserControl5.Instance.BringToFront();

            }
            else
            {
                UserControl5.Instance.BringToFront();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl6.Instance))
            {
                panel7.Controls.Add(UserControl6.Instance);
                UserControl6.Instance.Dock = DockStyle.Fill;
                UserControl6.Instance.BringToFront();

            }
            else
            {
                UserControl6.Instance.BringToFront();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl7.Instance))
            {
                panel7.Controls.Add(UserControl7.Instance);
                UserControl7.Instance.Dock = DockStyle.Fill;
                UserControl7.Instance.BringToFront();

            }
            else
            {
                UserControl7.Instance.BringToFront();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl8.Instance))
            {
                panel7.Controls.Add(UserControl8.Instance);
                UserControl8.Instance.Dock = DockStyle.Fill;
                UserControl8.Instance.BringToFront();

            }
            else
            {
                UserControl8.Instance.BringToFront();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl9.Instance))
            {
                panel7.Controls.Add(UserControl9.Instance);
                UserControl9.Instance.Dock = DockStyle.Fill;
                UserControl9.Instance.BringToFront();

            }
            else
            {
                UserControl9.Instance.BringToFront();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (!panel7.Controls.Contains(UserControl10.Instance))
            {
                panel7.Controls.Add(UserControl10.Instance);
                UserControl10.Instance.Dock = DockStyle.Fill;
                UserControl10.Instance.BringToFront();

            }
            else
            {
                UserControl10.Instance.BringToFront();
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

        }
    }
}