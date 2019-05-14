using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_DATABASE_MANAGEMENT_SYSTEM
{
    public partial class UserControl5 : UserControl
    {
        private static UserControl5 _instance;
        public static UserControl5 Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl5();
                }
                return _instance;

            }
        }
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }
    }
}
